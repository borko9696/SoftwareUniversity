using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Game_of_Names
{
    class GameOfNames
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int maxScore = 0;
            string winner = string.Empty;

            for (int i = 0; i < lines; i++)
            {
                string name = Console.ReadLine();
                int score = int.Parse(Console.ReadLine());
                
                int sum = score;

                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j] % 2 == 0)
                    {
                        sum += name[j];
                    }
                    else
                    {
                        sum -= name[j];
                    }
                }

                if (sum > maxScore)
                {
                    maxScore = sum;
                    winner = name;
                }
            }
            
            Console.WriteLine("The winner is {0} - {1} points", winner, maxScore);
        }
    }
}
