using System;
using System.Linq;

namespace MinMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Array.Sort(input);

            long min = input.Min(); long max = input.Max(); long total = input.Sum();

            Console.WriteLine((total - max) + " " + (total - min));

        }
    }
}
