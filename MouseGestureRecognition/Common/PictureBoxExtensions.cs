using MouseGestureRecognition.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseGestureRecognition.Common
{
    public static class PictureBoxExtensions
    {
        public static void DrawPoint(this PictureBox pictureBox,Pen pen, DrawingPoint point)
        {
            using (var g = pictureBox.CreateGraphics())
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawEllipse(pen, point.X, point.Y, point.Size, point.Size);
            }
        }
    }
}
