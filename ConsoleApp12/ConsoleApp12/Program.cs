using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleapp6
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int left = n;
            int rev = 0;
            int rev1 = 0;
            int rev2 = 0;
            int r = left % 10;
            rev = rev + r;
            left = left / 10;
            r = left % 10;
            rev1 = rev1 + r;
            left = left / 10;
            r = left % 10;
            rev2 = rev2 + r;
            for (int i = 1; i <= rev; i++)
            {
                for (int y = 1; y <= rev1; y++)
                {
                    for (int w = 1; w <= rev2; w++)
                    {
                        Console.WriteLine(i + " " + "*" + " " + y + " " + "*" + " " + w + " " + "=" + " " + i * y * w + ";");
                    }
                }
            }

        }
    }
}