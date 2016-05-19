using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'y' };
            List<char> digits = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            char input = char.Parse(Console.ReadLine());

            if (digits.Contains(input))
            {
                Console.WriteLine("digit");
            }
            else if (vowels.Contains(input))
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("It's another symbol");
            }
        }
    }
}
