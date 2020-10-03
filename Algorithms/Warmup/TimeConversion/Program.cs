using System;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();

            var amOrpm = time.Substring(8);

            var hour = Int32.Parse(time.Substring(0, 2));

            var minute = Int32.Parse(time.Substring(3, 2));

            var sec = Int32.Parse(time.Substring(6, 2));

            if (hour != 12 && amOrpm == "PM")
            {
                hour += 12;
            }

            if (hour == 12 && amOrpm == "AM")
            {
                hour -= 12;
            }

            Console.WriteLine(hour.ToString("D2") + ":" + minute.ToString("D2") + ":" + sec.ToString("D2"));


        }
    }
}
