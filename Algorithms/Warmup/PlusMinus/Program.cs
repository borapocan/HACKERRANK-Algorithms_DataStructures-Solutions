using System;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int negatives = 0;

            int positives = 0;

            int zeros = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positives++;
                }
                else if (arr[i] < 0)
                {
                    negatives++;
                }
                else
                {
                    zeros++;
                }
            }

            float positivesFloat = (float)positives;

            float negativesFloat = negatives;

            float zerosFloat = zeros;

            float arrLength = arr.Length;

            Console.WriteLine(positivesFloat / arrLength);

            Console.WriteLine(negativesFloat / arrLength);

            Console.WriteLine(zerosFloat / arrLength);

        }
    }
}
