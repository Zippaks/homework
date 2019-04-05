using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
                sum += number;
                
            }
            int sumOthers = sum - max;
            if (sumOthers == max)
            {
                Console.WriteLine($"Yes\nSum = {max}");
            }
            else
            {
                Console.WriteLine($"No\nDiff = {Math.Abs(max - sumOthers)}");
            }
        }
    }
}
