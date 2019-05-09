namespace CollegeManagement.Data
{
    public sealed class Student : User
    {
        public Student() : base()
        {
            Percentile = 99;
        }
        public Student(int id, string name, string department, int percentile): base(id, name, department)
        {
            Percentile = percentile;
        }
        public int Percentile { get; set; }
        public bool IsPercentileBetweenZeroToHundred()
        {
            return Percentile >= 0 && Percentile <= 100;
        }
        public new bool IsIdHasPositiveValue()
        {
            return Id > 0;
        }
    }
}
