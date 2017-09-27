using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            string toHex = Convert.ToString(inputNum,16);
            string toBinary = Convert.ToString(inputNum, 2);
            Console.WriteLine(toHex.ToUpper());
            Console.WriteLine(toBinary);
        }
    }
}
