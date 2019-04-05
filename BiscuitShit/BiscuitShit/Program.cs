using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiscuitShit
{
    class Program
    {
        static void Main(string[] args)
        {
            int batch = int.Parse(Console.ReadLine());


            for (int i = 1; i <= batch; i++)
            {
                bool flour = false;
                bool eggs = false;
                bool sugar = false;
                string product = string.Empty;
                

                while (true)
                {
                    product = Console.ReadLine();
                    if (product == "flour")
                    {
                        flour = true;
                    }
                    else if (product == "eggs")
                    {
                        eggs = true;
                    }
                    else if (product == "sugar")
                    {
                        sugar = true;
                    }
                    if (product == "Bake!")
                    {
                        if (flour && eggs && sugar)
                        {
                            Console.WriteLine($"Baking batch number {i}...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The batter should contain flour, eggs and sugar!");
                        }
                    }

                }                
               
            }
        }
    }
}
