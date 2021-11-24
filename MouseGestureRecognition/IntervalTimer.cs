using System;
using System.Windows.Forms;

namespace MouseGestureRecognition
{
    public class IntervalTimer : IDisposable
    {
        private Timer _timer;
        private int _tick = 1;

        public IntervalTimer(int interval)
        {
            _timer = new Timer();
            _timer.Interval = interval;
        }

        public void Start(Action onTick, Func<int,bool> end)
        {
            _timer.Tick += (o, e) =>
            {
                if (end(_tick))
                    _timer.Stop();
                onTick();
                _tick++;
            };
            _timer.Start();
        }

        public void Dispose() => _timer.Dispose();
    }
}
