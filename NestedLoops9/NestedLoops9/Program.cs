using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoops9
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int max = int.MinValue;
            string winner = "";
            while (name != "STOP")
            {
                int sum = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    char current = name[i];
                    sum += (int)current;
                    if (sum > max)
                    {
                        max = sum;
                        winner = name;
                    }
                }

                name = Console.ReadLine();
            }

            Console.WriteLine($"Winner is {winner} - {max}");
        }
    }
}
