using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            int digit = 0;
            int number = 0;
            for (int i = firstNum; i <= secondNum; i++)
            {
                //string num = i.ToString(); не е нужен.. знаем, че винаги работим с 6-цифрени числа
                number = i;
                for (int j = 6; j >= 1; j--)
                {
                    digit = number % 10;  //взимаме последното число
                    number = number / 10;    // после го махаме
                    if (j % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
                evenSum = 0;
                oddSum = 0;


            }





        }
    }
}
