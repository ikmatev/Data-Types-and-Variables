using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int fromNum = int.Parse(Console.ReadLine());
            int toNum = int.Parse(Console.ReadLine());
            for (int a = fromNum; a <= toNum; a++)
            {
                Console.Write($"{Convert.ToChar(a)} ");
            }
            Console.WriteLine();
        }
    }
}
