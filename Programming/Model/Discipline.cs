namespace Programming.Model
{
    public class Discipline
    {
        private int _mark;

        public Discipline()
        {

        }

        public Discipline(string disciplineName,
                          string examDate,
                          int mark)
        {
            DisciplineName = disciplineName;
            ExamDate = examDate;
            Mark = mark;
        }

        public string DisciplineName {get; set;}

        public string ExamDate {get; set;}

        public int Mark
        {
            get => _mark;
            set
            {
                if (2 > value || value > 5)
                {
                    throw new System.ArgumentException(
                        "the value of the mark field should be between 2 (unsatisfactory) and 5 (excellent)");
                }
                _mark = value;
            }
        }
    }
}