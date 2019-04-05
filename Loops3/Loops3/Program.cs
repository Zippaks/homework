using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFirst = int.Parse(Console.ReadLine());
            int numSecond = int.Parse(Console.ReadLine());
            int number = 0;
            int sum = 0;
            int sum1 = 0;
            int number1 = 0;
            int thirdNum;
            
            for (int i = numFirst; i <= numSecond; i++)
            {
                sum = 0;
                sum1 = 0;
                number = i;
                number1 = i;
                while(true)
                {
                    sum = number % 10;
                    number /= 10;
                    sum += number % 10;
                    break;
                }
                
                while(true)
                {
                    sum1 = (number1 / 1000) % 10;
                    sum1 += (number1 / 10000) % 10;
                    break;
                }
                if (sum1 == sum)
                {
                    Console.Write(i + " ");
                }               
                else if (sum1 < sum)
                {
                    thirdNum = (number / 10) % 10;
                    sum1 += thirdNum;
                    
                    if (sum == sum1)
                    {
                        Console.Write(i + " ");
                    }
                    
                }
                else if (sum < sum1)
                {
                    thirdNum = (number / 10) % 10;
                    sum += thirdNum;
                    
                    if (sum == sum1)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
