using System;

namespace TimeTracker
{
    public class ClockDisplay
    {
        private NumberDisplay _hours;
        private NumberDisplay _minutes;
        private NumberDisplay _seconds;
        private bool _showSeconds;

        public ClockDisplay(int h, int m, bool showSeconds)
        {
            _hours = new NumberDisplay(24);
            _minutes = new NumberDisplay(60);
            _seconds = new NumberDisplay(60);
            _showSeconds = showSeconds;
            SetTime(h, m, 0);
        }

        public void SetTime(int h, int m, int s)
        {
            _hours.Number = h;
            _minutes.Number = m;
            _seconds.Number = s;
        }

        public void TimeTick()
        {
            _seconds.Increment();

            if (_seconds.Number == 0)
            {
                _minutes.Increment();

                if (_minutes.Number == 0)
                {
                    _hours.Increment();
                }
            }
        }

        public string GetTime()
        {
            string timeStr = $"{_hours.GetDisplayNumber()}:{_minutes.GetDisplayNumber()}";

            if (_showSeconds)
            {
                timeStr += $":{_seconds.GetDisplayNumber()}";
            }

            return timeStr;
        }
    }
}
