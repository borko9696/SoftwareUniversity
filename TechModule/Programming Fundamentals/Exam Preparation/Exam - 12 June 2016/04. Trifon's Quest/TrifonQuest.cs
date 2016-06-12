namespace _04.Trifon_s_Quest
{
    #region

    using System;
    using System.Linq;

    #endregion

    class TrifonQuest
    {
        static void Main(string[] args)
        {
            long health = long.Parse(Console.ReadLine());
            int[] rowCol = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int row = rowCol[0];
            int col = rowCol[1];

            var matrix = new char[row, col];
            var turns = 0;
            for (int i = 0; i < row; i++)
            {
                var input = Console.ReadLine().ToCharArray();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            var hero = new Behavior();
            for (int i = 0; i < col; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < row; j++)
                    {
                        var obstacle = matrix[j, i];
                        switch (obstacle)
                        {
                            case 'F':
                                health -= turns / 2;
                                turns++;
                                break;
                            case 'H':
                                health += turns / 3;
                                turns++;
                                break;
                            case 'T':
                                turns += 3;
                                break;
                            case 'E':
                                turns++;
                                break;
                        }

                        if (health <= 0)
                        {
                            hero.Dead = true;
                            hero.Row = j;
                            hero.Col = i;
                            break;
                        }
                    }
                }
                else
                {
                    for (int k = row - 1; k >= 0; k--)
                    {
                        var obstacle = matrix[k, i];
                        switch (obstacle)
                        {
                            case 'F':
                                health -= turns / 2;
                                turns++;
                                break;
                            case 'H':
                                health += turns / 3;
                                turns++;
                                break;
                            case 'T':
                                turns += 3;
                                break;
                            case 'E':
                                turns++;
                                break;
                        }

                        if (health <= 0)
                        {
                            hero.Dead = true;
                            hero.Row = k;
                            hero.Col = i;
                            break;
                        }
                    }
                }

                if (hero.Dead)
                {
                    break;
                }
            }

            if (hero.Dead)
            {
                Console.WriteLine("Died at: [{0}, {1}]", hero.Row, hero.Col);
            }
            else
            {
                Console.WriteLine("Quest completed!");
                Console.WriteLine("Health: {0}", health);
                Console.WriteLine("Turns: {0}", turns);
            }
        }
    }

    class Behavior
    {
        public Behavior()
        {
            this.Dead = false;
        }

        public int Col { get; set; }

        public bool Dead { get; set; }

        public int Row { get; set; }
    }
}