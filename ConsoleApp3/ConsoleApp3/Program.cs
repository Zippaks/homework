using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            int diff = 0;
            for (int i = 0; i < number; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                if (number == 1)
                {
                    sum = num1 + num2; break;
                }
                diff = sum * 2 - (num1 + num2);
                if (diff != sum && i != 0)
                {
                    if (diff > max)
                    {
                        max = diff / 2;
                    }

                }
                sum = num1 + num2;
            }
            if (diff == 0 || number == 1)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={max}");
            }


        }

    }
}