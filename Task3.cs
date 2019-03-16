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
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            int counterDays = 0;
            int counterNormalDays = 0;

            while (counterDays < 5 && ownedMoney < neededMoney)
            {
                string command = Console.ReadLine();


                if (command == "save")
                {
                    double moneyS = double.Parse(Console.ReadLine());
                    ownedMoney += moneyS;
                    counterDays = 0;
                }
                if (command == "spend")
                {
                    double moneySp = double.Parse(Console.ReadLine());
                    ownedMoney -= moneySp;
                    if (ownedMoney < 0)
                        ownedMoney = 0;
                    counterDays++;

                }
                counterNormalDays++;
            }
            if (counterDays == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine($"{counterNormalDays}");
            }
            if (ownedMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {counterNormalDays} days.");


            }
        }
    }
}