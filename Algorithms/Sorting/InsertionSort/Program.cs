using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), x => Convert.ToInt32(x));

            int i, j, temp;

            for (i = 0; i < n; i++)
            {
                temp = arr[i];

                for (j = i - 1; j >= 0 && arr[j] > temp; j--)
                {
                    arr[j + 1] = arr[j];

                    Console.WriteLine("{0}", string.Join(" ", arr));
                }

                arr[j + 1] = temp;
            }

            Console.WriteLine("{0}", string.Join(" ", arr));
        }

    }

}
