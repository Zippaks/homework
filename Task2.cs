using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            int possibleBadGrades = int.Parse(Console.ReadLine());
            int counter = 0;
            decimal sumMark = 0;
            int counterMarks = 0;
            string lastProblem = string.Empty;
            while (counter < possibleBadGrades)
            {
                string nameOftask = Console.ReadLine();

                if (nameOftask == "Enough")
                {
                    Console.WriteLine($"Average score: {sumMark / counterMarks:F2}");
                    Console.WriteLine($"Number of problems: {counterMarks}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }
                decimal mark = decimal.Parse(Console.ReadLine());
                counterMarks++;
                if (mark <= 4)
                {
                    counter++;
                }
                sumMark += mark;
                lastProblem = nameOftask;


            }
            if (counter >= possibleBadGrades)
            {
                Console.WriteLine($"You need a break, {counter} poor grades.");

            }



        }
    }
}