using System;

namespace Programming.Model
{
    public class Rectangle
    {
        private static int _allRectanglesCount;

        private double _length;

        private double _width;

        private int _id;

        public Rectangle()
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public Rectangle(double length,
                         double width,
                         string color,
                         Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public Point2D Center { get; set; }

        public string Color { get; set; }

        public int Id
        {
            get => _id;
        }

        public static int AllRectanglesCount
        {
            get => _allRectanglesCount;
        }

        public double Length
        {
            get => _length;
            set
            {
                Validator.AssertOnPositiveValue(nameof(Length), value);
                _length = value;
            }
        }

        public double Width
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(nameof(Width), value);
                _width = value;
            }
        }
    }
}