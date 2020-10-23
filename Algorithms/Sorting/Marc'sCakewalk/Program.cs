using System;
using System.Linq;

namespace MarcsCakewalk
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), x => Convert.ToInt32(x));

            int[] cSorted = c.OrderByDescending(y => y).ToArray();

            double count = 0;

            for (int i = 0; i < n; i++)
            {
                double sum = Math.Pow(2.0, i) * cSorted[i];

                count += sum;
            }

            Console.WriteLine(count);

        }

    }

}
