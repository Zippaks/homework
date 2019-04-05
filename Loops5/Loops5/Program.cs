using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops5
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            int check = 0; // If the value of flag is 1 then the number is negative( "notPrime") and if its 0 =>("prime")
            int method = 0;
            int prime = 0;
            int notPrime = 0;
            string command = Console.ReadLine();
            while (command != "stop")
            {
                int num = int.Parse(command);
                while (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    
                    break;
                }
                switch (num)
                {
                    case 0: break;

                }
                while (num > 0)
                {
                    
                    method = num / 2;
                    for (int i = 2; i <= method; i++)     //check
                    {
                        if (num % i == 0)
                        {
                            notPrime += num;
                            check = 1;  // negative
                            break;
                        }
                    }
                    if (check == 0)  //prime
                    {
                        prime += num;
                    }
                    check = 0;
                    break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {prime}");
            Console.WriteLine($"Sum of all non prime numbers is: {notPrime}");

        }
    }
}
