using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool inputConvert = Convert.ToBoolean(input);
            if (inputConvert == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
