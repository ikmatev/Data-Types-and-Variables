using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int imageCount = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int percentOfAll = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());
            long timeToFilterAllImage = imageCount * (long)filterTime;
            int imageToUpload = (int)Math.Ceiling(imageCount *(double)percentOfAll/100);
            long timeToUploadImage = imageToUpload * (long)uploadTime;
            long totalTime = timeToFilterAllImage + timeToUploadImage;
            TimeSpan formatedTime = TimeSpan.FromSeconds(totalTime);
            string output = formatedTime.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(output);
        }
    }
}
