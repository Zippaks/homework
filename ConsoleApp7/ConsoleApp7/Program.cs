using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            double shirina = double.Parse(Console.ReadLine());
            double duljina = double.Parse(Console.ReadLine());
            double visochina = double.Parse(Console.ReadLine());
            double srednaVisochina = double.Parse(Console.ReadLine());
            double vRoom = (srednaVisochina + 0.40) * 2 * 2;
            double vRocket = shirina * duljina * visochina;

            if (vRocket / vRoom >= 3 || vRocket / vRoom <= 10)
            {
                Console.WriteLine($"The spacecraft holds {Math.Floor(vRocket / vRoom)} astronauts.");
            }
            else if (vRocket / vRoom < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else
            {
                Console.WriteLine("The spacecraft is too big.");
            }


        }
    }
}
