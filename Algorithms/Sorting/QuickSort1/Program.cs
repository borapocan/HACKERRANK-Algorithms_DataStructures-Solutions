using System;
using System.Collections.Generic;

namespace QuickSort1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), x => Convert.ToInt32(x));

            int p = arr[0];

            List<int> left = new List<int>(); List<int> equal = new List<int>(); List<int> right = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < p)
                {
                    left.Add(arr[i]);
                }
                else if (arr[i] > p)
                {
                    right.Add(arr[i]);
                }
                else
                {
                    equal.Add(arr[i]);
                }
            }

            left.AddRange(equal); left.AddRange(right);

            Console.WriteLine("{0}", string.Join(" ", left));
        }
    }
}
