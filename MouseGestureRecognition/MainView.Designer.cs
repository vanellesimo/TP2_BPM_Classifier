
namespace MouseGestureRecognition
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkDrawPoints = new System.Windows.Forms.CheckBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.nIterations = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.chkRejection = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTolerance = new System.Windows.Forms.TextBox();
            this.nStates = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblOutputLabel = new System.Windows.Forms.Label();
            this.btnDecide = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblInterval = new System.Windows.Forms.Label();
            this.nInterval = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.lblms = new System.Windows.Forms.Label();
            this.lblLabel = new System.Windows.Forms.Label();
            this.nSequence = new System.Windows.Forms.NumericUpDown();
            this.lblSequence = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nStates)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSequence)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 417);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkDrawPoints);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.nIterations);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.chkRejection);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTolerance);
            this.groupBox2.Controls.Add(this.nStates);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnRun);
            this.groupBox2.Controls.Add(this.lblOutputLabel);
            this.groupBox2.Controls.Add(this.btnDecide);
            this.groupBox2.Controls.Add(this.btnTrain);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 174);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Size = new System.Drawing.Size(1267, 243);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hidden Markov Model";
            // 
            // chkDrawPoints
            // 
            this.chkDrawPoints.AutoSize = true;
            this.chkDrawPoints.Checked = true;
            this.chkDrawPoints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDrawPoints.Location = new System.Drawing.Point(923, 110);
            this.chkDrawPoints.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkDrawPoints.Name = "chkDrawPoints";
            this.chkDrawPoints.Size = new System.Drawing.Size(118, 36);
            this.chkDrawPoints.TabIndex = 24;
            this.chkDrawPoints.Text = "Draw";
            this.chkDrawPoints.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(1069, 167);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(176, 67);
            this.btnStop.TabIndex = 23;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // nIterations
            // 
            this.nIterations.Location = new System.Drawing.Point(704, 110);
            this.nIterations.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.nIterations.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nIterations.Name = "nIterations";
            this.nIterations.Size = new System.Drawing.Size(179, 38);
            this.nIterations.TabIndex = 22;
            this.nIterations.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "Iterations:";
            // 
            // chkRejection
            // 
            this.chkRejection.AutoSize = true;
            this.chkRejection.Checked = true;
            this.chkRejection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRejection.Location = new System.Drawing.Point(296, 167);
            this.chkRejection.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkRejection.Name = "chkRejection";
            this.chkRejection.Size = new System.Drawing.Size(173, 36);
            this.chkRejection.TabIndex = 20;
            this.chkRejection.Text = "Rejection";
            this.chkRejection.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tolerance:";
            // 
            // txtTolerance
            // 
            this.txtTolerance.Location = new System.Drawing.Point(296, 105);
            this.txtTolerance.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtTolerance.Name = "txtTolerance";
            this.txtTolerance.Size = new System.Drawing.Size(228, 38);
            this.txtTolerance.TabIndex = 18;
            this.txtTolerance.Text = "0.01";
            // 
            // nStates
            // 
            this.nStates.Location = new System.Drawing.Point(296, 43);
            this.nStates.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.nStates.Name = "nStates";
            this.nStates.Size = new System.Drawing.Size(120, 38);
            this.nStates.TabIndex = 17;
            this.nStates.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Number of States:";
            // 
            // btnRun
            // 
            this.btnRun.Enabled = false;
            this.btnRun.Location = new System.Drawing.Point(1069, 95);
            this.btnRun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(176, 67);
            this.btnRun.TabIndex = 15;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblOutputLabel
            // 
            this.lblOutputLabel.AutoSize = true;
            this.lblOutputLabel.Location = new System.Drawing.Point(523, 185);
            this.lblOutputLabel.Name = "lblOutputLabel";
            this.lblOutputLabel.Size = new System.Drawing.Size(0, 32);
            this.lblOutputLabel.TabIndex = 14;
            // 
            // btnDecide
            // 
            this.btnDecide.Enabled = false;
            this.btnDecide.Location = new System.Drawing.Point(888, 167);
            this.btnDecide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecide.Name = "btnDecide";
            this.btnDecide.Size = new System.Drawing.Size(176, 67);
            this.btnDecide.TabIndex = 13;
            this.btnDecide.Text = "Decide";
            this.btnDecide.UseVisualStyleBackColor = true;
            this.btnDecide.Click += new System.EventHandler(this.btnDecide_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Enabled = false;
            this.btnTrain.Location = new System.Drawing.Point(707, 167);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(176, 67);
            this.btnTrain.TabIndex = 12;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.lblInterval);
            this.groupBox1.Controls.Add(this.nInterval);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtLabel);
            this.groupBox1.Controls.Add(this.lblms);
            this.groupBox1.Controls.Add(this.lblLabel);
            this.groupBox1.Controls.Add(this.nSequence);
            this.groupBox1.Controls.Add(this.lblSequence);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(1267, 174);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(899, 88);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(176, 50);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(171, 98);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(116, 32);
            this.lblInterval.TabIndex = 19;
            this.lblInterval.Text = "Interval:";
            // 
            // nInterval
            // 
            this.nInterval.Location = new System.Drawing.Point(296, 93);
            this.nInterval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nInterval.Name = "nInterval";
            this.nInterval.Size = new System.Drawing.Size(235, 38);
            this.nInterval.TabIndex = 18;
            this.nInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(899, 31);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 50);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(637, 33);
            this.txtLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(239, 38);
            this.txtLabel.TabIndex = 16;
            // 
            // lblms
            // 
            this.lblms.AutoSize = true;
            this.lblms.Location = new System.Drawing.Point(536, 110);
            this.lblms.Name = "lblms";
            this.lblms.Size = new System.Drawing.Size(52, 32);
            this.lblms.TabIndex = 7;
            this.lblms.Text = "ms";
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(536, 41);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(94, 32);
            this.lblLabel.TabIndex = 15;
            this.lblLabel.Text = "Label:";
            // 
            // nSequence
            // 
            this.nSequence.Location = new System.Drawing.Point(296, 33);
            this.nSequence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nSequence.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nSequence.Name = "nSequence";
            this.nSequence.Size = new System.Drawing.Size(120, 38);
            this.nSequence.TabIndex = 14;
            this.nSequence.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblSequence
            // 
            this.lblSequence.AutoSize = true;
            this.lblSequence.Location = new System.Drawing.Point(27, 38);
            this.lblSequence.Name = "lblSequence";
            this.lblSequence.Size = new System.Drawing.Size(259, 32);
            this.lblSequence.TabIndex = 13;
            this.lblSequence.Text = "Sequence Number:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 851);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1267, 69);
            this.panel2.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1267, 69);
            this.progressBar1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 417);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1267, 434);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 920);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainView";
            this.Text = "Mouse Gesture Recognition";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nStates)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSequence)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblms;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblOutputLabel;
        private System.Windows.Forms.Button btnDecide;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.NumericUpDown nInterval;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.NumericUpDown nSequence;
        private System.Windows.Forms.Label lblSequence;
        private System.Windows.Forms.NumericUpDown nStates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTolerance;
        private System.Windows.Forms.CheckBox chkRejection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nIterations;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox chkDrawPoints;
    }
}