using System;
using System.Linq;

namespace VeryBigSum
{
    class Solution
    {

        static long aVeryBigSum(long[] ar)
        {
            return ar.Sum();
        }

        static void Main(string[] args)
        {
           

            int arCount = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));

            long result = aVeryBigSum(ar);

            Console.WriteLine(result);
        }
    }
}
