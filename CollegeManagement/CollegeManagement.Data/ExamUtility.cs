namespace CollegeManagement.Data
{
    public static class ExamUtility
    {
        public static string Topper(Student student)
        {
            if(student.Percentile == 100)
            {
                return student.Name;
            }
            return $" {student.Name} is not a Topper";
        }
    }
}
