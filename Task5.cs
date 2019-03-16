sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int size = a * b;
            int piece = 0;

            while (size > 0)
            {
                string command = Console.ReadLine();

                if (command == "STOP")
                {
                    Console.WriteLine($"{size - piece} pieces are left.");
                    break;

                }
                int parche = int.Parse(command);
                piece += parche;
                if (piece > size)
                {
                    Console.WriteLine($"No more cake left! You need {piece - size} pieces more.");
                    break;
                }





            }
        }
    }
}
