namespace CollegeManagement.Data.Extensions
{
    public static class StudentExtensions
    {
        public static string GetDepartment(this Teacher teacher)
        {
            return teacher.Department;
        }
        public static int IntExtension(this int a)
        {
            return a;
        }
    }
}
