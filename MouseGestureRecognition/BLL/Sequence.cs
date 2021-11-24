using Accord.Math;
using System.Collections.Generic;
using System.Drawing;

namespace MouseGestureRecognition.BLL
{
    public class Sequence
    {
        private Queue<Point> _value;
        public Queue<Point> Value { get => _value; }
        public int Length { get => _value.Count; }
        public int Output { get; set; }
        public int Count { get => _value.Count; }

        private int _maxElements = -1;
        public Sequence(int maxElements = -1) 
        {
            _value = new Queue<Point>();
            _maxElements = maxElements;
        }

        public bool IsValid
        {
            get
            {
                return _value.Count != 0;
            }
        }

        public void Add(Point item)
        {
            if (_maxElements==-1)
                _value.Enqueue(item);
            else
            {
                if (_value.Count == _maxElements)
                    _value.Dequeue();
                _value.Enqueue(item);
            }
        }

        public double[][] Preprocess()
        {
            double[][] result = new double[_value.Count][];
            int i = 0;
            foreach (var item in _value)
            {
                result[i] = new double[] { item.X, item.Y };
                i++;
            }

            double[][] zscores = Accord.Statistics.Tools.ZScores(result);

            return zscores.Add(10);
        }
    }
}
