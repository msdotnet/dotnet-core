namespace CollegeManagement.Data
{
    public class User
    {
        public User()
        {
            Id = 100;
            Name = "Avishek";
            Department = "CSE";
        }

        public User(int id, string name, string department)
        {
            Id = id;
            Name = name;
            Department = department;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public bool IsIdHasPositiveValue()
        {
            return Id >= 0;
        }
    }
}
