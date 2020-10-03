using System;

namespace Kangaroo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x1v1x2v2 = Array.ConvertAll(Console.ReadLine().Split(' '), i => Convert.ToInt32(i));

            int x1 = x1v1x2v2[0]; int v1 = x1v1x2v2[1]; int x2 = x1v1x2v2[2]; int v2 = x1v1x2v2[3];

            if (v1 == v2)
            {
                if (x1 == x2)
                {
                    Console.Write("YES");
                }
                else
                {
                    Console.Write("NO");
                }
            }
            else
            {
                int i = Math.Abs((x2 - x1) / (v2 - v1));

                bool satisfied = x1 + (i * v1) == x2 + (i * v2);

                if (satisfied)
                {
                    Console.Write("YES");
                }
                else
                {
                    Console.Write("NO");
                }
            } 
        }
    }
}
