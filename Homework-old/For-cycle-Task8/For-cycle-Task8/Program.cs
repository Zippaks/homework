using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_cycle_Task8
{
    class Program
    {
        static void Main(string[] args)
        {// Трябва да изчилсява и отпечатва сумата от стойностите на гласните букви в string-a
            string text = Console.ReadLine();           
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                switch (letter)
                {
                    case 'a': sum++; break;
                    case 'e': sum += 2; break;
                    case 'i': sum += 3; break;
                    case 'o': sum += 4; break;
                    case 'u': sum += 5; break;
                    default: break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
