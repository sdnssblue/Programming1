using System;

namespace Programming.Model
{
    public class Subject
    {
        private int _mark;

        public Subject()
        {

        }

        public Subject(string name,
                          string examDate,
                          int mark)
        {
            Name = name;
            ExamDate = examDate;
            Mark = mark;
        }

        public string Name { get; set; }

        public string ExamDate { get; set; }

        public int Mark
        {
            get => _mark;
            set
            {
                if (value < 2 || value > 5)
                {
                    throw new ArgumentException(
                        "the value of the mark field should be between 2 (unsatisfactory) and 5 (excellent)");
                }
                _mark = value;
            }
        }
    }
}