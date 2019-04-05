using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoops1
{
    class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine());
            double suvenir = double.Parse(Console.ReadLine());
            double hotel = double.Parse(Console.ReadLine());
            double fuel = 420 / 100 * 7;
            double sum1 = 3 * food + 3 * suvenir;
            double moneyForFuel = 29.4 * 1.85;          
            double sum = 0;            
            double day1 = hotel * 0.90;             
            double day2 = hotel * 0.85;            
            double day3 = hotel * 0.80;
                
            
            sum = day1 + day2 + day3 +sum1 + moneyForFuel;
            Console.WriteLine($"Money needed: {sum:F2}");

            
            

        }
    }
}
