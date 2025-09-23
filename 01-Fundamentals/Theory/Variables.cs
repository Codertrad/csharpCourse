using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Theory
{
    internal class Variables
    {
        private static string name = "John Doe";
        private static int age = 30;
        private static double height = 1.75;
        private static bool isEmployed = true;
        private static char middleInitial = 'A';
        private static decimal salary = 50000.50m;
        private static DateTime birthDate = new DateTime(1993, 5, 15);

        public static void RunVariables()
        {
            Console.WriteLine($"Hello World, my name is {name} and I am {age} years old.");
            Console.WriteLine($"Height: {height}m | Employed: {isEmployed}");
            Console.WriteLine($"Middle Initial: {middleInitial}");
            Console.WriteLine($"Salary: {salary:C}"); // {C} -> formato moneda
            Console.WriteLine($"Birth Date: {birthDate:dd/MM/yyyy}"); // formato de fecha
        }
    }
}
