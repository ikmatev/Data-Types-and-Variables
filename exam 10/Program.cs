using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_10
{
    class Program
    {
        static void Main(string[] args)
        {
            byte cents = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(cents * 100);
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            long seconds = (long)minutes * 60;
            long milliseconds = seconds * 1000;
            long microseconds = milliseconds * 1000;
            decimal nanoseconds = (decimal)microseconds * 1000;
            Console.WriteLine($"{cents} centuries = {years} years = {days} days = " +
                $"{hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds}" +
                $" milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
