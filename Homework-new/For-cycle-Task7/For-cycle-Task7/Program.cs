using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_cycle_Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;
            for (int i = 1; i <= number; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even += num;
                }
                else
                {
                    odd += num;
                }
            }
            if (even == odd)
            {
                Console.WriteLine($"Yes\nSum = {even}");
            }
            else
            {
                Console.WriteLine($"No\nDiff = {Math.Abs(odd - even)}");
            }
        }
    }
}
