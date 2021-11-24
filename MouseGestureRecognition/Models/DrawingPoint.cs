using System.Drawing;

namespace MouseGestureRecognition.Models
{
    public class DrawingPoint
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Size { get; private set; }

        private DrawingPoint(int x, int y, int size)
        {
            X = x-(size/2);
            Y = y-(size/2);
            Size = size;
        }

        public static DrawingPoint CreateFromPoint(Point point, int size)
        {
            return new DrawingPoint(point.X, point.Y, size);
        }
    }
}
