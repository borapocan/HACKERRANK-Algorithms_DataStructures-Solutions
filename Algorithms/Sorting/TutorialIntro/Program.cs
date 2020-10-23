using System;

namespace TutorialIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = Convert.ToInt32(Console.ReadLine());

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), x => Convert.ToInt32(x));

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == v)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
