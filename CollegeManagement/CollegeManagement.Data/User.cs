namespace CollegeManagement.Data
{
    public abstract class User
    {
        public User()
        {
            Id = 100;
            Name = "Avishek";
            Department = Department.CSE;
        }

        public User(int id, string name, Department department)
        {
            Id = id;
            Name = name;
            Department = department;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
        public abstract string GetName();  
        public virtual bool IsIdHasPositiveValue()
        {
            return Id >= 0;
        }
    }
}
