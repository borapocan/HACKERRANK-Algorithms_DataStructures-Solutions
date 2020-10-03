using System;
using System.Collections.Specialized;
using System.Linq;
using System.Threading;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), i => Convert.ToInt32(i));

            int max = input.Max();

            var times = 0;

            for (int i = 0; i < n; i++)
            {
                if (input[i] == max)
                {
                    times++;
                }
            }

            Console.WriteLine(times);
        }
    }
}
