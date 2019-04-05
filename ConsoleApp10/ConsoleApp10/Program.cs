using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int passangers = int.Parse(Console.ReadLine());
            int stops = int.Parse(Console.ReadLine());

            for (int i = 1; i <= stops; i++)
            {
                int kachva = int.Parse(Console.ReadLine());
                int sliza = int.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    kachva += 2;
                }
                else if (i % 2 == 0)
                {
                    sliza += 2;
                }
                passangers -= sliza;
                passangers += kachva;
                    
            }
            Console.WriteLine(passangers);



        }
    }
}
