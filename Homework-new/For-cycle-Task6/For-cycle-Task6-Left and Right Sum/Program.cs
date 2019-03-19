using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_cycle_Task6_Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberLeft = 0;
            int numberRight = 0;
            for (int counter = 1; counter <= n; counter++)
            {
                int numberOne = int.Parse(Console.ReadLine());
                numberLeft += numberOne;
            }
            for (int counter = 1; counter <= n; counter++)
            {
                int numberOne = int.Parse(Console.ReadLine());
                numberRight += numberOne;
            }
            if (numberLeft == numberRight)
            {
                Console.WriteLine($"Yes, sum = {numberLeft}");
            }
            else
            {
                int diff = Math.Abs(numberLeft - numberRight);
                Console.WriteLine($"No, diff = {diff}");
            }


        }
    }
}
