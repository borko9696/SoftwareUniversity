using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Substring
{
    class Substring
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                var currentChar = text[i];
                if (currentChar == Search)
                {
                    hasMatch = true;

                    int end = jump + 1;

                    if (end + i > text.Length)
                    {
                        end = text.Length - i;
                    }

                    string matchedString = text.Substring(i, end);
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}

