using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            double evenSum = 0;
            double oddSum = 0;

            if (n == 0)
            {
                oddMin = 0;
                oddMax = 0;
                evenMin = 0;
                evenMax = 0;
                
            }           
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    double number = double.Parse(Console.ReadLine());
                     
                    if (i % 2 == 0)
                    {
                        evenSum += number;
                        if (number > evenMax)
                        {

                            evenMax = number;
                            if (n == 1)
                            {
                                evenMax = 0;
                            }
                        }
                        if (number < evenMin)
                        {

                            evenMin = number;
                            if (n == 1)
                            {
                                evenMin = 0;
                            }
                        }
                    }
                    if (i % 2 != 0)
                    {
                        oddSum += number;
                        if (number > oddMax)
                        {

                            oddMax = number;
                            
                        }
                        if (number < oddMin)
                        {

                            oddMin = number;
                        }
                    }
                    
                }
                
            }
            Console.WriteLine($"OddSum={oddSum:F2},");
            if (oddMin != 0) Console.WriteLine($"OddMin={oddMin:F2},");
            else if (oddMin == 0) Console.WriteLine("OddMin=No,");

            if (oddMax != 0) Console.WriteLine($"OddMax={oddMax:F2},");
            else Console.WriteLine("OddMax=No,");
            Console.WriteLine($"EvenSum={evenSum:F2},");
            while (n == 1)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
                break;
            }
            while (n != 1)
            {
                if (evenMin != 0) Console.WriteLine($"EvenMin={evenMin:F2},");
                else Console.WriteLine("EvenMin=No,");
                if (evenMax != 0) Console.WriteLine($"EvenMax={evenMax:F2}");
                else Console.WriteLine("EvenMax=No");
                break;
            }
            

        }
    }
}
