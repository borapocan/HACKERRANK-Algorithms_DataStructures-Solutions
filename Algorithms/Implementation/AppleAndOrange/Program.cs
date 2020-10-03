using System;
using System.Globalization;
using System.Linq;

namespace AppleAndOrange
{
    class Program
    {

        static int CountFruits(int[] arr, int tree, int s, int t)
        {
            int count = 0;

            foreach (int i in arr)
            {
                int j = tree + i;

                if (j >= s && j <= t)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] st = Array.ConvertAll(Console.ReadLine().Split(' '), i => Convert.ToInt32(i));

            int s = st[0]; int t = st[1];

            int[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), i => Convert.ToInt32(i));

            int a = ab[0]; int b = ab[1];

            int[] mn = Array.ConvertAll(Console.ReadLine().Split(' '), i => Convert.ToInt32(i));

            int m = mn[0]; int n = mn[1];

            int[] aTimesM = Array.ConvertAll(Console.ReadLine().Split(' '), i => Convert.ToInt32(i));
            
            int[] bTimesN = Array.ConvertAll(Console.ReadLine().Split(' '), i => Convert.ToInt32(i));

            if (m == aTimesM.Length && n == bTimesN.Length)
            {
                Console.WriteLine(CountFruits(aTimesM, a, s, t));

                Console.WriteLine(CountFruits(bTimesN, b, s, t));
            }
        }
    }
}
