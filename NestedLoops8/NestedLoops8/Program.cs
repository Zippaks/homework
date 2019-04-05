using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoops8
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double storedMoney = 0;
            while (destination != "End")
            {
                double needMoney = double.Parse(Console.ReadLine());
                double savedMoney = 0;
                while (savedMoney < needMoney)
                {
                   double money = double.Parse(Console.ReadLine());
                    savedMoney += money;
                }
                Console.WriteLine($"Goint to {destination}!");
                destination = Console.ReadLine();
                
                
                
            }












        }
    }
}
