using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug
{
    public class DebugMe
    {
        public static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double timeInSeconds = distance * timePerMeter;
            double additionalSeconds = Math.Floor(distance / 50);
            additionalSeconds *= 30;
            
            double totalTime = timeInSeconds + additionalSeconds;

            if (worldRecord < totalTime)
            {
                Console.WriteLine($"No! He was {Math.Abs(worldRecord - totalTime):F2} seconds slower.");
               
            }
            else
            {
                Console.WriteLine($"Yes! The new record is {totalTime:F2} seconds.");
            }
        }
    }
}