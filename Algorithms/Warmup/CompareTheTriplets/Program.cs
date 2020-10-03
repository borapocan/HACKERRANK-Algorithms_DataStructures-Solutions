using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace CompareTheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] aPoints = Console.ReadLine().Split(' ');

            int a0 = Convert.ToInt32(aPoints[0]);

            int a1 = Convert.ToInt32(aPoints[1]);

            int a2 = Convert.ToInt32(aPoints[2]);

            string[] bPoints = Console.ReadLine().Split(' ');

            int b0 = Convert.ToInt32(bPoints[0]);

            int b1 = Convert.ToInt32(bPoints[1]);

            int b2 = Convert.ToInt32(bPoints[2]);

            int[] aPointsInt = new int[] { a0, a1, a2 };

            int[] bPointsInt = new int[] { b0, b1, b2 };

            int pointA = 0;

            int pointB = 0;

            for (int i = 0; i < aPointsInt.Length; i++)
            {
                if (aPointsInt[i] > bPointsInt[i])
                {
                    pointA++;
                }
                else if (aPointsInt[i] < bPointsInt[i])
                {
                    pointB++;
                }
            }

            Console.WriteLine(pointA + " " + pointB);

        }
    }
}
