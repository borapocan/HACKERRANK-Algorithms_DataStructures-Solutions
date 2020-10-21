using System;
using System.Linq;

namespace StrongPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string password = Console.ReadLine();

            int count = 0;

            char[] numbers = "0123456789".ToCharArray();

            char[] upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            char[] lowerCase = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            char[] specialChars = "!@#$%^&*()-+".ToCharArray();

            int missingChars = 6 - password.Length;

            if (password.Intersect(numbers).Count() == 0)
            {
                count++;
            }
            if (password.Intersect(upperCase).Count() == 0)
            {
                count++;
            }
            if (password.Intersect(lowerCase).Count() == 0)
            {
                count++;
            }
            if (password.Intersect(specialChars).Count() == 0)
            {
                count++;
            }

            if (count > missingChars)
            {
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine(missingChars);
            }
        }
    }
}
