using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Letters
{
    class TriplesOfLetters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 'a'; i < 'a' + n; i++)
            {
                for (int j = 'a'; j < 'a' + n; j++)
                {
                    for (int k = 'a'; k < 'a' + n; k++)
                    {
                        Console.WriteLine(((char)i).ToString() + (char)j + (char)k);
                    }
                }
            }
        }
    }
}
