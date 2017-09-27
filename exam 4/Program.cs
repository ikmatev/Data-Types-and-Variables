using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string trimString = input.Remove(0, 2);
            int todecimal = int.Parse(trimString, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(todecimal);
        }
    }
}
