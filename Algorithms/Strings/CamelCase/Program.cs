using System;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int count = 1;

            foreach (var i in s)
            {
                if (char.IsUpper(i))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
