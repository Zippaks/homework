using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops1
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int number = int.Parse(num);
            int reminder = 0;
            for (int i = 0; i < num.Length; i++)  //брой редове...
            {
                

                reminder = number % 10;
                number /= 10;
                if (reminder == 0)
                {
                    Console.WriteLine("ZERO");
                    continue;
                }
                char symbol = (char)(reminder + 33);
                for (int j = 0; j < reminder; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
