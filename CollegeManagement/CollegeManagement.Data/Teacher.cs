namespace CollegeManagement.Data
{
    public class Teacher : User
    {
        public Teacher() : base()
        {
            Salary = 10000.50;
        }
        public Teacher(int id, string name = "Avishek", string department = "CSE", double salary = 10000.50) : base(id, name, department)
        {
            Salary = salary;
        }
        public override string GetName()
        {
            return $"Teacher Name is: {Name}";
        }
        public override bool IsIdHasPositiveValue()
        {
            return Id > 0 && Id < 100000;
        }
        public double Salary { get; set; }
    }
}
