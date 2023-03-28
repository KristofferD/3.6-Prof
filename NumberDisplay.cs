using System;

namespace TimeTracker
{
    public class NumberDisplay
    {
        private int _number;
        private int _maxNumber;

        public NumberDisplay(int maxNumber)
        {
            _number = 0;
            _maxNumber = maxNumber;
        }

        public int Number
        {
            get { return _number; }
            set
            {
                if (value < 0 || value >= _maxNumber)
                {
                    throw new ArgumentException($"Invalid number: {value}");
                }
                _number = value;
            }
        }

        public string GetDisplayNumber()
        {
            if (_number < 10)
            {
                return $"0{_number}";
            }
            else
            {
                return $"{_number}";
            }
        }

        public void Increment()
        {
            _number++;
            if (_number >= _maxNumber)
            {
                _number = 0;
            }
        }
    }
}
