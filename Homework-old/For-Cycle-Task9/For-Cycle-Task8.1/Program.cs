using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Cycle_Task8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double laundry = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int even = 0;
            
            int sum = 10;
            int toy = 0;
            int badBrother = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    badBrother += 1;
                    even += sum;
                    sum += 10;
                }
                else
                {
                    toy += 1;
                }
            }
            int moneyFromToys = toy * toyPrice;
            int savedMoney = even - badBrother;
            int money = moneyFromToys + savedMoney;
            if (money >= laundry)
            {
                Console.WriteLine($"Yes! {(money - laundry):F2}");
            }
            else
            {
                Console.WriteLine($"No! {(laundry - money):F2}");
            }

        }
    }
}
