namespace NewGameSnake
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading;

    using global::SnakeGame;

    internal class SnakeGame
    {
        private static void Main()
        {
            if (!File.Exists(@"..\..\highscore.txt"))
            {
                using (File.Create(@"..\..\highscore.txt"))
                {
                }
            }
            

            Console.CursorVisible = false;
            Menu.ConsoleMenu();

            Console.BufferHeight = Console.WindowHeight;
            ConsoleKeyInfo comand = Console.ReadKey();
            if (comand.Key == ConsoleKey.Spacebar)
            {
                Console.Clear();

                string readHighScore = @"..\..\highscore.txt";
                StreamReader reader = new StreamReader(readHighScore);

                using (reader)
                {
                    string line = reader.ReadLine();
                    Console.SetCursorPosition(35, 1);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Highscores:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine();
                    int count = 1;

                    if (line == null)
                    {
                        Console.WriteLine("There is no highscore :(");
                    }

                    while (line != null)
                    {
                        Console.WriteLine("{0}. {1}", count, line);
                        line = reader.ReadLine();
                        count++;
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Press the DEL button if you want to erase the scoreboard!");
                ConsoleKeyInfo delScoreBoard = Console.ReadKey();
                
                if (delScoreBoard.Key == ConsoleKey.Delete)
                {
                    File.Delete(@"..\..\highscore.txt");
                    Console.WriteLine("The scoreboard has been deleted!");
                }
                Console.WriteLine();
            }

            if (comand.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.SetCursorPosition(35, 10);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Level 1");
                Thread.Sleep(3000);
                Console.Clear();

                bool level = true;
                int levelChangeScore = 100;
                int firstLevelBonusPoints = 0;

                byte right = 0;
                byte left = 1;
                byte down = 2;
                byte up = 3;

                Position[] directions = new Position[]
                                            {
                                                new Position(0, 1), //дясно   
                                                new Position(0, -1), //ляво
                                                new Position(1, 0), //долу
                                                new Position(-1, 0), //горе
                                            };
                int snakeSpeed = 100;
                int direction = right;

                int startSnake = 5;

                level1:
                direction = right;
                //food location
                Random randomNumberGenerator = new Random();
                Position food = new Position(
                    randomNumberGenerator.Next(0, Console.WindowHeight),
                    randomNumberGenerator.Next(0, Console.WindowWidth));

                //food drawing 
                Console.SetCursorPosition(food.col, food.row);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("@");

                Queue<Position> snakeElements = new Queue<Position>();

                //snake begining
                for (int i = 0; i <= startSnake; i++)
                {
                    snakeElements.Enqueue(new Position(0, i));
                }

                //Level 1
                while (level)
                {
                    //moving the snake without pressing a button
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo userInput = Console.ReadKey();
                        //user direction
                        if (userInput.Key == ConsoleKey.RightArrow)
                        {
                            if (direction != left)
                            {
                                direction = right;
                            }
                        }
                        if (userInput.Key == ConsoleKey.LeftArrow)
                        {
                            if (direction != right)
                            {
                                direction = left;
                            }
                        }
                        if (userInput.Key == ConsoleKey.DownArrow)
                        {
                            if (direction != up)
                            {
                                direction = down;
                            }
                        }
                        if (userInput.Key == ConsoleKey.UpArrow)
                        {
                            if (direction != down)
                            {
                                direction = up;
                            }
                        }
                    }

                    Position snakeHead = Enumerable.Last(snakeElements);
                    Position nextDirection = directions[direction];
                    Position snakeNewHead = new Position(
                        snakeHead.row + nextDirection.row,
                        snakeHead.col + nextDirection.col);

                    //game over
                    if (snakeNewHead.row < 0 || snakeNewHead.col < 0 || snakeNewHead.row >= Console.WindowHeight
                        || snakeNewHead.col >= Console.WindowWidth || snakeElements.Contains(snakeNewHead))
                    {
                        Console.Clear();
                        Console.SetCursorPosition(35, 10);
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(@"Game Over!
                               Your points are: {0}", (snakeElements.Count - 6) * 100);
                        Console.WriteLine();
                        // Highscore Method / read and print from highscore.txt
                        int currentScore = (snakeElements.Count - 6) * 100; // scores for level 1
                        HighScore(currentScore);

                        return;
                    }

                    //element adding for snake movement
                    snakeElements.Enqueue(snakeNewHead);
                    Console.SetCursorPosition(snakeNewHead.col, snakeNewHead.row);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("*");

                    //food crossing
                    if (snakeNewHead.col == food.col && snakeNewHead.row == food.row)
                    {
                        do
                        {
                            food = new Position(
                                randomNumberGenerator.Next(0, Console.WindowHeight),
                                randomNumberGenerator.Next(0, Console.WindowWidth));
                        }
                        while (snakeElements.Contains(food));
                        Console.SetCursorPosition(food.col, food.row);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("@");
                        snakeSpeed -= 4;
                    }
                    else
                    {
                        Position lastElement = snakeElements.Dequeue();
                        Console.SetCursorPosition(lastElement.col, lastElement.row);
                        Console.Write(" ");
                    }

                    //slowdown the program process
                    Thread.Sleep(snakeSpeed);

                    if ((snakeElements.Count - 6) * 100 + firstLevelBonusPoints == levelChangeScore)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(35, 5);
                        Console.WriteLine("Congratulations!");
                        Console.WriteLine("You are a champion.");
                        Console.WriteLine();
                        Console.WriteLine("Press Y to become a mazerunner");
                        Console.WriteLine("Press N to keep playing classic snake");

                        ConsoleKeyInfo mazeRunner = Console.ReadKey();
                        
                        if (mazeRunner.Key == ConsoleKey.Y)
                        {
                            level = false;
                        }
                        else if (mazeRunner.Key == ConsoleKey.N)
                        {
                            firstLevelBonusPoints += 200;
                            startSnake += levelChangeScore/100;
                            Console.Clear();
                            goto level1;
                        }
                    }
                }

                //level 2

                Console.Clear();
                Console.SetCursorPosition(35, 10);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Level 2");
                Thread.Sleep(4000);
                Console.Clear();

                level = true;
                right = 0;
                left = 1;
                down = 2;
                up = 3;

                directions = new Position[]
                                 {
                                     new Position(0, 1), //дясно   
                                     new Position(0, -1), //ляво
                                     new Position(1, 0), //долу
                                     new Position(-1, 0), //горе
                                 };

                direction = right;

                //Obstacle drawing
                var obstaclesLevel2 = new List<Position>();

                for (int i = 0; i < Console.WindowWidth - 20; i++)
                {
                    obstaclesLevel2.Add(new Position(6, i));
                    obstaclesLevel2.Add(new Position(12, 20 + i));
                    obstaclesLevel2.Add(new Position(18, i));
                }

                foreach (Position obstacle in obstaclesLevel2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.SetCursorPosition(obstacle.col, obstacle.row);
                    Console.Write("#");
                }

                //food location
                randomNumberGenerator = new Random();
                do
                {
                    food = new Position(
                        randomNumberGenerator.Next(0, Console.WindowHeight),
                        randomNumberGenerator.Next(0, Console.WindowWidth));
                }
                while (snakeElements.Contains(food) || obstaclesLevel2.Contains(food));

                //food drawing 
                Console.SetCursorPosition(food.col, food.row);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("@");

                snakeElements = new Queue<Position>();

                //snake begining
                for (int i = 0; i <= 5; i++)
                {
                    snakeElements.Enqueue(new Position(0, i));
                }

                while (level)
                {
                    //moving the snake without pressing a button
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo userInput = Console.ReadKey();

                        //user direction
                        if (userInput.Key == ConsoleKey.RightArrow)
                        {
                            if (direction != left)
                            {
                                direction = right;
                            }
                        }
                        if (userInput.Key == ConsoleKey.LeftArrow)
                        {
                            if (direction != right)
                            {
                                direction = left;
                            }
                        }
                        if (userInput.Key == ConsoleKey.DownArrow)
                        {
                            if (direction != up)
                            {
                                direction = down;
                            }
                        }
                        if (userInput.Key == ConsoleKey.UpArrow)
                        {
                            if (direction != down)
                            {
                                direction = up;
                            }
                        }
                    }

                    Position snakeHead = Enumerable.Last(snakeElements);
                    Position nextDirection = directions[direction];
                    Position snakeNewHead = new Position(
                        snakeHead.row + nextDirection.row,
                        snakeHead.col + nextDirection.col);

                    //game over
                    if (snakeNewHead.row < 0 || snakeNewHead.col < 0 || snakeNewHead.row >= Console.WindowHeight
                        || snakeNewHead.col >= Console.WindowWidth || snakeElements.Contains(snakeNewHead)
                        || obstaclesLevel2.Contains(snakeNewHead))
                    {
                        Console.Clear();
                        Console.SetCursorPosition(35, 10);
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(@"Game Over!
                              Your points are: {0}", ((snakeElements.Count - 6) * 100) + levelChangeScore);
                        Console.WriteLine();
                        // Highscore Method / read and print from highscore.txt
                        int currentScore = ((snakeElements.Count - 6) * 100) + levelChangeScore; // score for level 2
                        HighScore(currentScore);

                        return;
                    }

                    //element adding for snake movement
                    snakeElements.Enqueue(snakeNewHead);
                    Console.SetCursorPosition(snakeNewHead.col, snakeNewHead.row);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("*");

                    //food crossing
                    if (snakeNewHead.col == food.col && snakeNewHead.row == food.row)
                    {
                        do
                        {
                            food = new Position(
                                randomNumberGenerator.Next(0, Console.WindowHeight),
                                randomNumberGenerator.Next(0, Console.WindowWidth));
                        }
                        while (snakeElements.Contains(food) || obstaclesLevel2.Contains(food));
                        Console.SetCursorPosition(food.col, food.row);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("@");
                        snakeSpeed -= 4;
                    }
                    else
                    {
                        Position lastElement = snakeElements.Dequeue();
                        Console.SetCursorPosition(lastElement.col, lastElement.row);
                        Console.Write(" ");
                    }

                    //slowdown the program process
                    Thread.Sleep(snakeSpeed);

                    if (((snakeElements.Count - 6) * 100) + levelChangeScore == levelChangeScore * 2)
                    {
                        level = false;
                    }
                }

                //level 3

                Console.Clear();
                Console.SetCursorPosition(35, 10);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Level 3");
                Thread.Sleep(4000);
                Console.Clear();

                level = true;
                right = 0;
                left = 1;
                down = 2;
                up = 3;

                directions = new Position[]
                                 {
                                     new Position(0, 1), //дясно   
                                     new Position(0, -1), //ляво
                                     new Position(1, 0), //долу
                                     new Position(-1, 0), //горе
                                 };

                direction = right;

                //Obstacle drawing
                var obstaclesLevel3 = new List<Position>();

                for (int i = 0; i < Console.WindowWidth / 3; i++)
                {
                    obstaclesLevel3.Add(new Position(5, 7 + i));
                    obstaclesLevel3.Add(new Position(10, 7 + i));
                    obstaclesLevel3.Add(new Position(15, 7 + i));
                    obstaclesLevel3.Add(new Position(20, 7 + i));

                    if (i < 19)
                    {
                        obstaclesLevel3.Add(new Position(i + 3, (Console.WindowWidth / 2) + 1));
                        obstaclesLevel3.Add(new Position(i + 3, (Console.WindowWidth / 2) - 2));
                    }

                    obstaclesLevel3.Add(new Position(5, (21 + Console.WindowWidth / 3) + i));
                    obstaclesLevel3.Add(new Position(10, (21 + Console.WindowWidth / 3) + i));
                    obstaclesLevel3.Add(new Position(15, (21 + Console.WindowWidth / 3) + i));
                    obstaclesLevel3.Add(new Position(20, (21 + Console.WindowWidth / 3) + i));
                }

                foreach (Position obstacle in obstaclesLevel3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.SetCursorPosition(obstacle.col, obstacle.row);
                    Console.Write("#");
                }

                //food location
                randomNumberGenerator = new Random();
                do
                {
                    food = new Position(
                        randomNumberGenerator.Next(0, Console.WindowHeight),
                        randomNumberGenerator.Next(0, Console.WindowWidth));
                }
                while (snakeElements.Contains(food) || obstaclesLevel3.Contains(food));

                //food drawing 
                Console.SetCursorPosition(food.col, food.row);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("@");

                snakeElements = new Queue<Position>();

                //snake begining
                for (int i = 0; i <= 5; i++)
                {
                    snakeElements.Enqueue(new Position(0, i));
                }

                while (level)
                {
                    //moving the snake without pressing a button
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo userInput = Console.ReadKey();

                        //user direction
                        if (userInput.Key == ConsoleKey.RightArrow)
                        {
                            if (direction != left)
                            {
                                direction = right;
                            }
                        }
                        if (userInput.Key == ConsoleKey.LeftArrow)
                        {
                            if (direction != right)
                            {
                                direction = left;
                            }
                        }
                        if (userInput.Key == ConsoleKey.DownArrow)
                        {
                            if (direction != up)
                            {
                                direction = down;
                            }
                        }
                        if (userInput.Key == ConsoleKey.UpArrow)
                        {
                            if (direction != down)
                            {
                                direction = up;
                            }
                        }
                    }

                    Position snakeHead = Enumerable.Last(snakeElements);
                    Position nextDirection = directions[direction];
                    Position snakeNewHead = new Position(
                        snakeHead.row + nextDirection.row,
                        snakeHead.col + nextDirection.col);

                    //game over
                    if (snakeNewHead.row < 0 || snakeNewHead.col < 0 || snakeNewHead.row >= Console.WindowHeight
                        || snakeNewHead.col >= Console.WindowWidth || snakeElements.Contains(snakeNewHead)
                        || obstaclesLevel3.Contains(snakeNewHead))
                    {
                        Console.Clear();
                        Console.SetCursorPosition(35, 10);
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(@"Game Over!
                              Your points are: {0}", ((snakeElements.Count - 6) * 100) + levelChangeScore * 2);
                        Console.WriteLine();
                        // Highscore Method / read and print from highscore.txt
                        int currentScore = ((snakeElements.Count - 6) * 100) + levelChangeScore * 2; // score for level 3
                        HighScore(currentScore);

                        return;
                    }

                    //element adding for snake movement
                    snakeElements.Enqueue(snakeNewHead);
                    Console.SetCursorPosition(snakeNewHead.col, snakeNewHead.row);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("*");

                    //food crossing
                    if (snakeNewHead.col == food.col && snakeNewHead.row == food.row)
                    {
                        do
                        {
                            food = new Position(
                                randomNumberGenerator.Next(0, Console.WindowHeight),
                                randomNumberGenerator.Next(0, Console.WindowWidth));
                        }
                        while (snakeElements.Contains(food) || obstaclesLevel3.Contains(food));
                        Console.SetCursorPosition(food.col, food.row);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("@");
                        snakeSpeed -= 4;
                    }
                    else
                    {
                        Position lastElement = snakeElements.Dequeue();
                        Console.SetCursorPosition(lastElement.col, lastElement.row);
                        Console.Write(" ");
                    }

                    //slowdown the program process
                    Thread.Sleep(snakeSpeed);

                }
                
            }
        }
        private static void HighScore(int currentScore)
        {
            Console.CursorVisible = true;
            Console.Write("Please enter your name or leave empty: ");
            string name = Console.ReadLine();
            if (name != "")
            {
                Console.WriteLine("Your score has been saved!");
                Console.WriteLine();
            }
            Dictionary<string, int> scoreBoard = new Dictionary<string, int>();

            MatchCollection matches;
            var rgx = new Regex(@"(\w+\s*\w*\s*\w*)\s-\s(\d+)");

            using (StreamReader reader = new StreamReader(@"..\..\highscore.txt"))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    matches = rgx.Matches(line);
                    foreach (Match match in matches)
                    {
                        scoreBoard.Add(match.Groups[1].ToString(), int.Parse(match.Groups[2].Value));
                        line = reader.ReadLine();
                    }
                }
            }
            name += " - " + currentScore;
            matches = rgx.Matches(name);

            foreach (Match match in matches)
            {
                scoreBoard.Add(match.Groups[1].ToString(), int.Parse(match.Groups[2].Value));
            }
            using (StreamWriter writer = new StreamWriter(@"..\..\highscore.txt"))
            {
                foreach (KeyValuePair<string, int> kvp in scoreBoard.OrderByDescending(p => p.Value))
                {
                    writer.WriteLine("{0} - {1}", kvp.Key, kvp.Value);
                }
            }
            Console.WriteLine();
        }
        //кординати на конзолата
        private struct Position
        {
            public int row;

            public int col;

            public Position(int row, int col)
            {
                this.row = row;
                this.col = col;
            }
        }
    }
}