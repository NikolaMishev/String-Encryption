using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice101
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                var currentChar = char.Parse(Console.ReadLine());

                var encrypted = Encrypt(currentChar);

                result += encrypted;
            }

            Console.WriteLine(result);
        }

        private static string Encrypt(char currentChar)
        {
            var askiiCode = (int)currentChar;

            var firstDigit = askiiCode;

            while (firstDigit >= 10)
            {
                firstDigit = firstDigit / 10;
            }

            var lastDigit = currentChar % 10;

            var firstLast = firstDigit.ToString() + lastDigit.ToString();

            var start = (char)(askiiCode + lastDigit);

            var end = (char)(askiiCode - firstDigit);

            var result = start + firstLast + end;

            return result;

        }
    }
}
