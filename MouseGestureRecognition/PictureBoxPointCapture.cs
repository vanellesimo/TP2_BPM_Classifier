using MouseGestureRecognition.Common;
using MouseGestureRecognition.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MouseGestureRecognition
{
    public class PictureBoxPointCapture
    {
        private PictureBox _pictureBox;
        private Pen _pen;
        private Point _currentMousePoint = Point.Empty;
        public PictureBoxPointCapture(PictureBox pictureBox)
        {
            _pen = new Pen(new SolidBrush(Color.Red));
            _pictureBox = pictureBox;
            _pictureBox.MouseMove += (o, e) => _currentMousePoint = e.Location;
        }

        public void CaptureCurrentMousePosition(Action<Point> onPointCaptured, bool drawPoint=true) 
        {
            if (_currentMousePoint.IsEmpty) return;
            if (drawPoint)
                _pictureBox.DrawPoint(_pen,DrawingPoint.CreateFromPoint(_currentMousePoint,10));
            onPointCaptured(_currentMousePoint); 
        }

        public void Clear() => _pictureBox.Invalidate();

        internal void SetBackgroundColor(string label)
        {
            if (string.IsNullOrEmpty(label)) return;
            if (label.ToLower() == "none") _pictureBox.BackColor = Color.White;
            else
                _pictureBox.BackColor = Color.FromName(label);
        }
    }
}
