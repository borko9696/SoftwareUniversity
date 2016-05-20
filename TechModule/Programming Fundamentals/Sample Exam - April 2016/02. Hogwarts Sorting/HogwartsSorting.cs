using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hogwarts_Sorting
{
    class HogwartsSorting
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int gryffindor = 0;
            int slytherin = 0;
            int ravenclaw = 0;
            int hufflepuff = 0;

            for (int i = 0; i < lines; i++)
            {
                string name = Console.ReadLine();

                string initials = name[0].ToString();
                int sumOfLetters = 0;

                for (int letter = 0; letter < name.Length; letter++)
                {
                    if (name[letter] == ' ')
                    {
                        initials += name[letter + 1];
                    }
                    else
                    {
                        sumOfLetters += (int)name[letter];
                    }
                }

                if (sumOfLetters % 4 == 0)
                {
                    gryffindor++;
                    Console.WriteLine("Gryffindor {0}{1}",sumOfLetters,initials);
                }
                if (sumOfLetters % 4 == 1)
                {
                    slytherin++;
                    Console.WriteLine("Slytherin {0}{1}", sumOfLetters, initials);
                }
                if (sumOfLetters % 4 == 2)
                {
                    ravenclaw++;
                    Console.WriteLine("Ravenclaw {0}{1}", sumOfLetters, initials);
                }
                if (sumOfLetters % 4 == 3)
                {
                    hufflepuff++;
                    Console.WriteLine("Hufflepuff {0}{1}", sumOfLetters, initials);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Gryffindor: {0}", gryffindor);
            Console.WriteLine("Slytherin: {0}", slytherin);
            Console.WriteLine("Ravenclaw: {0}", ravenclaw);
            Console.WriteLine("Hufflepuff: {0}", hufflepuff);
        }
    }
}
