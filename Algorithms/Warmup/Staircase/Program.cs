using System;
using System.Collections.Generic;
using System.Linq;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string space = new String(' ', n - i);

                string square = new String('#', i);

                Console.WriteLine(space + square);

            }
        }
    }
}
