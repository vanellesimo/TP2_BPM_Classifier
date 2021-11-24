using MouseGestureRecognition.BLL;
using MouseGestureRecognition.Common;
using System;
using System.Windows.Forms;

namespace MouseGestureRecognition
{
    public partial class MainView : Form
    {
        private PictureBoxPointCapture _pictureBox;
        private Sequence _sequence;
        private Database _database;
        private HiddenMarkovModel hmm;
        private bool _stop = false;
        public MainView()
        {
            InitializeComponent();
            _pictureBox = new PictureBoxPointCapture(pictureBox1);
            _sequence = new Sequence();
            _database = new Database();
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e) =>
            e.KeyChar.IsEnter(() =>
                new IntervalTimer((int)nInterval.Value).Start(
                    () => _pictureBox.CaptureCurrentMousePosition(_sequence.Add),
                    (tick) => tick == (int)nSequence.Value));
        private void btnAdd_Click(object sernder, EventArgs e)
        {
            if (!txtLabel.Text.IsValid() || !_sequence.IsValid) return;
            _database.Add(_sequence, txtLabel.Text);
            btnTrain.Enabled = _database.Samples.Count >= 10;
            Reset();
        }

        private void Reset()
        {
            _sequence = new Sequence();
            _pictureBox.Clear();
            txtLabel.Focus();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            hmm = new HiddenMarkovModel((int)nStates.Value, Double.Parse(txtTolerance.Text), chkRejection.Checked);
            hmm.Train(_database, (int)nIterations.Value);
            btnDecide.Enabled = true;
            btnRun.Enabled = true;
        }

        private void btnDecide_Click(object sender, EventArgs e)
        {
            if (!_sequence.IsValid) return;
            var label = _database.MapResult(hmm.Decide(_sequence));
            lblOutputLabel.Text = $"Class: {label}";
            _pictureBox.SetBackgroundColor(label);
            Reset();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            _stop = btnRun.Enabled = false;
            btnStop.Enabled = true;
            _sequence = new Sequence((int)nSequence.Value);
            new IntervalTimer((int)nInterval.Value).Start(
                () =>
                {
                    _pictureBox.CaptureCurrentMousePosition(_sequence.Add, chkDrawPoints.Checked);
                    if (_sequence.Count == (int)nSequence.Value)
                    {
                        var label = _database.MapResult(hmm.Decide(_sequence));
                        lblOutputLabel.Text = $"Class: {label}";
                        _pictureBox.SetBackgroundColor(label);
                    }
                },
                (_) => _stop);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _sequence = new Sequence((int)nSequence.Value);
            _pictureBox.Clear();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnRun.Enabled = _stop = true;
            btnStop.Enabled = false;
        }
    }
}
