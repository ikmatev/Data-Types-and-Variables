using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string input =Console.ReadLine();
            try
            {
                checked
                {
                    long check = Convert.ToInt64(input);
                    Console.WriteLine($"{check} can fit in:");

                    if (check <= sbyte.MaxValue && check >= sbyte.MinValue)
                    {
                        Console.WriteLine("* sbyte");
                    }
                    if (check <= byte.MaxValue && check >= byte.MinValue)
                    {
                        Console.WriteLine("* byte");
                    }
                    if (check <= short.MaxValue && check >= short.MinValue)
                    {
                        Console.WriteLine("* short");
                    }
                    if (check <= ushort.MaxValue && check >= ushort.MinValue)
                    {
                        Console.WriteLine("* ushort");
                    }
                    if (check <= int.MaxValue && check >= int.MinValue)
                    {
                        Console.WriteLine("* int");
                    }
                    if (check <= uint.MaxValue && check >= uint.MinValue)
                    {
                        Console.WriteLine("* uint");
                    }
                    if (check <= long.MaxValue && check >= long.MinValue)
                    {
                        Console.WriteLine("* long");
                    }
                }
            }
            catch (OverflowException)
            {
               Console.WriteLine($"{input} can't fit in any type");
            }
            
        }
    }
}
