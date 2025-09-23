using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Exercises
{
    internal class AverageStudents
    {
        private static int currentAssignments = 5;

        // Campos (variables de clase)
        private static int sophia1 = 93;
        private static int sophia2 = 87;
        private static int sophia3 = 98;
        private static int sophia4 = 95;
        private static int sophia5 = 100;

        private static int nicolas1 = 80;
        private static int nicolas2 = 83;
        private static int nicolas3 = 82;
        private static int nicolas4 = 88;
        private static int nicolas5 = 85;

        private static int zahirah1 = 84;
        private static int zahirah2 = 96;
        private static int zahirah3 = 73;
        private static int zahirah4 = 85;
        private static int zahirah5 = 79;

        private static int jeong1 = 90;
        private static int jeong2 = 92;
        private static int jeong3 = 98;
        private static int jeong4 = 100;
        private static int jeong5 = 97;


        public static void RunAverageStudends() 
        {
            int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
            int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
            int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

            decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
            decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
            decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
            decimal jeongScore = (decimal)jeongSum / currentAssignments;

            Console.WriteLine("Sophia: " + sophiaScore + " A");
            Console.WriteLine("Nicolas: " + nicolasScore + " B");
            Console.WriteLine("Zahirah: " + zahirahScore + " B");
            Console.WriteLine("Jeong: " + jeongScore + " A");
        }
    }
}
