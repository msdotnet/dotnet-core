namespace CollegeManagement.Data
{
    public sealed class Student : User
    {
        public Student() : base()
        {
            Percentile = 99;
        }
        public Student(int id, string name = "Jagu", string department = "CSE", int percentile = 99): base(id, name, department)
        {
            Percentile = percentile;
        }
        public int Percentile { get; set; }
        public bool IsPercentileBetweenZeroToHundred()
        {
            return Percentile >= 0 && Percentile <= 100;
        }
        public override string GetName()
        {
            return $"Student Name is: {Name}";
        }
        public new bool IsIdHasPositiveValue()
        {
            return Id > 100000;
        }
        public static int PassingMark { get; set; }
        public static bool HasPassed(int percentile)
        {
            return percentile >= 40;
        }
    }
}
