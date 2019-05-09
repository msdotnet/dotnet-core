using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<double>() { 4.5, 6.4, 5.1 };
            var numbers2 = new List<double>() { 4.5, 6.4, 5.1 };
            numbers[1] = 1.4;
            numbers.Add(10.5);
            numbers.AddRange(numbers2);

            var result = 0.0;
            foreach (var number in numbers)
            {
                result = result + number;
            }
            GetData<List<double>>(numbers);
            Console.WriteLine($"Result: {result}");
        }
        public static string GetData<T>(T objectValue)
        {
            var stringValue = objectValue;
            return stringValue.ToString();
        }
    }
}
