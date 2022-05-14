using System;

namespace Programming.Model.Geometry
{
    public class Rectangle
    {
        private static int _allRectanglesCount;

        private int _height;

        private int _width;

        private int _id;

        public Rectangle()
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public Rectangle(int height,
                         int width,
                         string color,
                         Point2D center)
        {
            Height = height;
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

        public int Height
        {
            get => _height;
            set
            {
                Validator.AssertOnPositiveValue(nameof(Height), value);
                _height = value;
            }
        }

        public int Width
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