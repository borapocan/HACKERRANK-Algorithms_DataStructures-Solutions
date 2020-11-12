using System;

namespace InsertionSortPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(" "), x => Convert.ToInt32(x));

            for (int i = 1; i < n; i++)
            {
                int last = arr[i];

                for (int j = i; j > 0; j--)
                {
                    if (arr[j - 1] > last)
                    {
                        arr[j] = arr[j - 1];
                    }
                    else
                    {
                        arr[j] = last;

                        break;
                    }
                }

                if (last < arr[0])
                {
                    arr[0] = last;
                }

                Console.WriteLine(String.Join(" ", arr));
            }
        }
    }
}
