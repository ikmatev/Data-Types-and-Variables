using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            sbyte hours = sbyte.Parse(Console.ReadLine());
            sbyte minutes = sbyte.Parse(Console.ReadLine());
            sbyte seconds = sbyte.Parse(Console.ReadLine());
            int totalSeconds = ((hours * 60 * 60) + (minutes * 60) + seconds);
            float meterPerSeconds = (float)meters / totalSeconds;
            float kilometers = (meters / 1000);
            float totalHours = hours + ((float)minutes / 60) + ((float)seconds / 60 / 60);
            float kilometersPerHour = kilometers / totalHours;
            float miles = (float)meters / 1609;
            float milesPerHour = miles / totalHours;
            Console.WriteLine(meterPerSeconds);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
