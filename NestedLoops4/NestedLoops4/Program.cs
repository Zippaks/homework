using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoops4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfFloors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            for (int floor = numOfFloors; floor >= 1; floor--)
            {
                for (int room = 0; room < rooms; room++)
                {
                    Console.Write($"{floor} {room}");
                }

                Console.WriteLine();
            }


        }
    }
}
