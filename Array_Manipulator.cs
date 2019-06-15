using System;
using System.Linq;
namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command;


            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArr = command.Split(" ");
                if (commandArr[0] == "exchange")
                {
                    int index = int.Parse(commandArr[1]);
                    
                    if (index >= 0 && index <= input.Length - 1)
                    {
                        
                        SplitArrayMethod(input, index);
                    }                   
                    else Console.WriteLine("Invalid index");



                }
                else if (commandArr[0] == "max")
                {
                    int max = int.MinValue;
                    if (commandArr[1] == "even")
                    {
                        FindMaxEven(input, max);
                    }
                    else if (commandArr[1] == "odd")
                    {
                        FindMaxOdd(input, max);
                    }

                }
                else if (commandArr[0] == "min")
                {
                    int min = int.MaxValue;
                    if (commandArr[1] == "even")
                    {
                        FindMinEven(input, min);
                    }
                    else if (commandArr[1] == "odd")
                    {
                        FindMinOdd(input, min);
                    }

                }


                else if (commandArr[0] == "first" || commandArr[0] == "last")
                {
                    int counter = int.Parse(commandArr[1]);
                    PrintFirstOrLastEvenOrOddElements(input, commandArr[0], counter, commandArr[2]);

                }




            }
            Console.WriteLine($"[{string.Join(", ", input)}]");


        }

        private static void FindMinOdd(int[] input, int min)
        {
            int holdPosition = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < min && input[i] % 2 != 0)
                {
                    min = input[i];
                    holdPosition = i;
                }

            }
            InvalidCountCheckMin(min, holdPosition);

        }

        private static void InvalidCountCheckMin(int min, int holdPosition)
        {
            if (min == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else Console.WriteLine(holdPosition);
        }

        private static void FindMinEven(int[] input, int min)
        {
            int holdPosition = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < min && input[i] % 2 == 0)
                {
                    min = input[i];
                    holdPosition = i;
                }

            }
            InvalidCountCheckMin(min, holdPosition);
        }

        private static void FindMaxOdd(int[] input, int max)
        {
            int holdPosition = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > max && input[i] % 2 != 0)
                {
                    max = input[i];
                    holdPosition = i;
                }

            }
            InvalidCountCheckMax(max, holdPosition);

        }

        private static void InvalidCountCheckMax(int max, int holdPosition)
        {
            if (max == int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else Console.WriteLine(holdPosition);
        }

        private static void FindMaxEven(int[] input, int max)
        {
            int holdPosition = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > max && input[i] % 2 == 0)
                {
                    max = input[i];
                    holdPosition = i;
                }

            }
            InvalidCountCheckMax(max, holdPosition);
        }

        private static void SplitArrayMethod(int[] input, int index)
        {
            int[] arrSplit = new int[index + 1];
            Array.Copy(input, arrSplit, index + 1);
            int currentIndex = 0;
            for (int i = index + 1; i < input.Length; i++)
            {
                input[currentIndex] = input[i];
                currentIndex++;
            }
            for (int i = 0; i < arrSplit.Length; i++)
            {
                input[currentIndex] = arrSplit[i];
                currentIndex++;
            }
            Console.WriteLine(string.Join(" ", input));
        }

        static void PrintFirstOrLastEvenOrOddElements(int[] input, string firstOrLast, int count, string type)
        {
            if (count > input.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int currentEvenCount = 0;
                int currentOddCount = 0;
                int[] evenElements = new int[input.Length];
                int[] oddElements = new int[input.Length];
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] % 2 == 0)
                    {
                        evenElements[currentEvenCount] = input[i];
                        currentEvenCount++;
                    }
                    else
                    {
                        oddElements[currentOddCount] = input[i];
                        currentOddCount++;
                    }
                }
                if (type == "odd" && count > currentOddCount)
                {
                    count = currentOddCount;
                }
                else if (type == "even" && count > currentEvenCount)
                {
                    count = currentEvenCount;
                }
                if (firstOrLast == "first")
                {
                    if (type == "odd")
                    {
                        Console.Write("[");
                        for (int i = 0; i < count; i++)
                        {
                            Console.Write(oddElements[i]);
                            if (i != count - 1) Console.Write(", ");
                        }
                        Console.WriteLine("]");
                    }
                    else if (type == "even")
                    {
                        Console.Write("[");
                        for (int i = 0; i < count; i++)
                        {
                            Console.Write(evenElements[i]);
                            if (i != count - 1) Console.Write(", ");
                        }
                        Console.WriteLine("]");
                    }
                }
                else if (firstOrLast == "last")
                {
                    if (type == "odd")
                    {
                        Console.Write("[");
                        for (int i = currentOddCount - count; i < currentOddCount; i++)
                        {
                            Console.Write(oddElements[i]);
                            if (i < currentOddCount - 1) Console.Write(", ");
                        }
                        Console.WriteLine("]");
                    }
                    else if (type == "even")
                    {
                        Console.Write("[");
                        for (int i = currentEvenCount - count; i < currentEvenCount; i++)
                        {
                            Console.Write(evenElements[i]);
                            if (i < currentEvenCount - 1) Console.Write(", ");
                        }
                        Console.WriteLine("]");
                    }
                }
            }
        }
    }
}
