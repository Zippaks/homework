using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            double gostIzpl = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int sum = 0;
            int price = 0;
            int guests = 0;
            
            while (command != "The restaurant is full")
            {
                
                int gosti = int.Parse(command);
                
                if (gosti < 5 && gosti > 0)
                {
                    price = 100 * gosti;
                    
                }
                else if (gosti >= 5)
                {
                    price = 70 * gosti;
                }
                guests += gosti;
                sum += price;
                command = Console.ReadLine();
            }
            if (command == "The restaurant is full")
            {if (sum - gostIzpl >= 0)
                {
                    Console.WriteLine($"You have {guests} guests and {sum - gostIzpl} leva left.");
                }
                else 
                {
                    Console.WriteLine($"You have {guests} guests and {sum} leva income, but no singer.");
                }
                
            }


        }
    }
}
