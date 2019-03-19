using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_cycle_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            for (int i = 1; i <= number; i++)
            {
                
                int num = int.Parse(Console.ReadLine());
                if (num < min)
                {
                    min = num;
                }
            }
            
            Console.WriteLine(min);


        }
    }
}
