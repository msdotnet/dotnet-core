using CollegeManagement.Data;
using System;


namespace CollegeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var teacher = new Teacher(0,"Sateesh"); 
            var student = new Student(0, department: "ECE");
            User user1 = new Teacher(0);
            User user2 = new Student(0);

            var isPositiveValue = teacher.IsIdHasPositiveValue();
            Console.WriteLine($"Is Teacher Id holding Positive value : {isPositiveValue}");
            Console.WriteLine($"Is Student Id holding Positive value : {student.IsIdHasPositiveValue()}");

            Console.WriteLine($"Between 1 - 100000 : {user1.IsIdHasPositiveValue()}");

            Console.WriteLine($"Between 1000001 + : {user2.IsIdHasPositiveValue()}");


            Console.WriteLine($"{teacher.GetName()}");
            Console.WriteLine($"{student.GetName()}");
            Console.WriteLine($"{user1.GetName()}");
            Console.WriteLine($"{user2.GetName()}");

            Console.WriteLine($"Is Student Percentile between 0 to 100 : {student.IsPercentileBetweenZeroToHundred()}");

            Console.ReadLine();
        }
    }
}
