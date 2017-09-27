using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int checkTo = int.Parse(Console.ReadLine());
            for (int num = 2; num <= checkTo; num++)
            {
                bool isPrime = true;
                for (int b = 2; b <= Math.Sqrt(num); b++)
                {
                    if (num % b == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{num} -> {isPrime}");
            }

        }
    }
}
