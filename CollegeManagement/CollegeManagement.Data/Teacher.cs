namespace CollegeManagement.Data
{
    public class Teacher : User
    {
        public Teacher() : base()
        {
            Salary = 10000.50;
        }
        public Teacher(int id, string name, string department, double salary) : base(id, name, department)
        {
            Salary = salary;
        }
        public double Salary { get; set; }
    }
}
