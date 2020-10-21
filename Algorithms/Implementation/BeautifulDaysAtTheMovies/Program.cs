using System;
using System.Linq;

namespace BeautifulDaysAtTheMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ijk = Array.ConvertAll(Console.ReadLine().Split(' '), x => Convert.ToInt32(x)); int i = ijk[0]; int j = ijk[1]; int k = ijk[2];

            int beautifulDays = 0;

            for (int y = i; y <= j; y++)
            {
                string reversedString = new string(y.ToString().Reverse().ToArray());

                int reversedInteger = int.Parse(reversedString);

                int res = Math.Abs(y - reversedInteger);

                if (res % k == 0)
                {
                    beautifulDays++;

                }
            }
            Console.WriteLine(beautifulDays);
        }
    }
}
