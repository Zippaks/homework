using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            string sushiType = Console.ReadLine();
            string restaurant = Console.ReadLine();
            int portions = int.Parse(Console.ReadLine());
            string nachin = Console.ReadLine();
            // prices
            double price = 0;
            int valid = 1;
            if (restaurant == "Sushi Zone")
            {
                valid = 0;
                if (sushiType == "sashimi") price = 4.99;
                if (sushiType == "maki") price = 5.29;
                if (sushiType == "uramaki") price = 5.99;
                if (sushiType == "temaki") price = 4.29;
            }
            else if (restaurant == "Sushi Time")
            {
                valid = 0;
                if (sushiType == "sashimi") price = 5.49;
                if (sushiType == "maki") price = 4.69;
                if (sushiType == "uramaki") price = 4.49;
                if (sushiType == "temaki") price = 5.19;
            }
            else if (restaurant == "Sushi Bar")
            {
                valid = 0;
                if (sushiType == "sashimi") price = 5.25;
                if (sushiType == "maki") price = 5.55;
                if (sushiType == "uramaki") price = 6.25;
                if (sushiType == "temaki") price = 4.75;
            }
            else if (restaurant == "Asian Pub")
            {
                valid = 0;
                if (sushiType == "sashimi") price = 4.50;
                if (sushiType == "maki") price = 4.80;
                if (sushiType == "uramaki") price = 5.50;
                if (sushiType == "temaki") price = 5.50;
            }
            else
            {
                valid = 1;
                Console.WriteLine($"{restaurant} is invalid restaurant!");
            }
            double sum = 0;
            sum = portions * price;
            if (nachin == "Y" && valid != 1)
            {
                sum = sum + (sum * 0.20);
                Console.WriteLine($"Total price: {Math.Ceiling(sum)} lv.");
            }
            else if (nachin =="N" && valid !=1)
            {
                sum = sum;
                Console.WriteLine($"Total price: {Math.Ceiling(sum)} lv.");
            }
        }
    }
}
