using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoops10
{
    class Program
    {
        static void Main(string[] args)
        {
            int batch = int.Parse(Console.ReadLine());
            int productCounter = 0;

            for (int i = 1; i <= batch; i++)
            {
                string products = string.Empty;
                if (products == "flour" || products == "eggs" || products == "sugar")
                {
                    productCounter++;
                }
                while (products != "Bake!")
                {
                    products = Console.ReadLine();
                    if (products == "flour" || products == "eggs" || products == "sugar")
                    {
                        productCounter++;
                    }
                }
                if (productCounter == 3)
                {
                    Console.WriteLine($"Baking batch number {i}...");
                }
                else
                {
                    Console.WriteLine("The batter should contain flour, eggs and sugar!");
                    while (productCounter < 3)
                    {
                        while (true)
                        {
                            products = Console.ReadLine();
                            if (products == "flour" || products == "eggs" || products == "sugar")
                            {
                                productCounter++;
                            }
                            if (products == "Bake!")
                            {
                                break;
                            }

                        }
                        if (productCounter < 3)
                        {
                            Console.WriteLine("The batter should contain flour, eggs and sugar!");
                        }
                    }
                    if (productCounter == 3)
                    {
                        Console.WriteLine($"Baking batch number {i}...");
                    }



                }
                productCounter = 0;
            }
        }
    }
}