using CollegeManagement.Data;
using System;


namespace CollegeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var teacher = new Teacher();
            var student = new Student(0, "Jagu", "CSE", 99);


            var isPositiveValue = teacher.IsIdHasPositiveValue();
            Console.WriteLine($"Is Teacher Id holding Positive value : {isPositiveValue}");
            Console.WriteLine($"Is Student Id holding Positive value : {student.IsIdHasPositiveValue()}");
            Console.WriteLine($"Is Student Percentile between 0 to 100 : {student.IsPercentileBetweenZeroToHundred()}");

            Console.ReadLine();
        }
    }
}
