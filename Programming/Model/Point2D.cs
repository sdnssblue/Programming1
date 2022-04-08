using System;

namespace Programming.Model
{
    public class Point2D
    {
        private int _x;

        private int _y;

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X
        {
            get => _x;
            private set
            {
                Validator.AssertOnPositiveValue(nameof(X), value);
                _x = value;
            }
        }

        public int Y
        {
            get => _y;
            private set
            {
                Validator.AssertOnPositiveValue(nameof(Y), value);
                _y = value;
            }
        }
    }
}
