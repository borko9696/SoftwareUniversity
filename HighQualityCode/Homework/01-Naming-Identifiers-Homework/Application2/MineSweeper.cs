namespace MineSweeper
{
    using System;
    using System.Collections.Generic;
    using Application2.Models;

    public class Minesweeper
    {
                private static void Main(string[] аргументи)
        {
            string command = string.Empty;
            char[,] mineField = CreateMineField();
            char[,] mines = PlaceMines();
            int points = 0;
            bool isMineHit = false;
            List<Player> champions = new List<Player>(6);
            int row = 0;
            int colum = 0;
            bool isNewGame = true;
            const int MaxTurns = 35;
            bool areTurnsMax = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine(
                        "Lets play MineSweeper!Try your luck and find a field without a mine in it"
                        + "Command 'top' shows highscore info , 'restart' starts a new game , 'exit' exits the game and says goodbye!");
                    DrawBoard(mineField);
                    isNewGame = false;
                }

                Console.Write("Please write row and colum  : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out colum)
                        && row <= mineField.GetLength(0) && colum <= mineField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        HighScore(champions);
                        break;
                    case "restart":
                        mineField = CreateMineField();
                        mines = PlaceMines();
                        DrawBoard(mineField);
                        isMineHit = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye , bye !");
                        break;
                    case "turn":
                        if (mines[row, colum] != '*')
                        {
                            if (mines[row, colum] == '-')
                            {
                                NextToMove(mineField, mines, row, colum);
                                points++;
                            }

                            if (MaxTurns == points)
                            {
                                areTurnsMax = true;
                            }
                            else
                            {
                                DrawBoard(mineField);
                            }
                        }
                        else
                        {
                            isMineHit = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nUnknown command\n");
                        break;
                }

                if (isMineHit)
                {
                    DrawBoard(mines);
                    Console.Write("\nHrrrrrr! You died a heroic death with  {0} points. " + "Tell us your name hero: ", points);
                    string playerName = Console.ReadLine();
                    Player newPlayer = new Player(playerName, points);
                    if (champions.Count < 5)
                    {
                        champions.Add(newPlayer);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < newPlayer.Points)
                            {
                                champions.Insert(i, newPlayer);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    champions.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Points.CompareTo(firstPlayer.Points));
                    HighScore(champions);

                    mineField = CreateMineField();
                    mines = PlaceMines();
                    points = 0;
                    isMineHit = false;
                    isNewGame = true;
                }

                if (areTurnsMax)
                {
                    Console.WriteLine("\nYey ! You opened 35 cells without dying");
                    DrawBoard(mines);
                    Console.WriteLine("Give us your name , hero: ");
                    string playerName = Console.ReadLine();
                    Player newPlayer = new Player(playerName, points);
                    champions.Add(newPlayer);
                    HighScore(champions);
                    mineField = CreateMineField();
                    mines = PlaceMines();
                    points = 0;
                    areTurnsMax = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("Vamoooo kabron , jejejeje");
            Console.Read();
        }

        private static void HighScore(List<Player> playerPoints)
        {
            Console.WriteLine("\nPoints:");
            if (playerPoints.Count > 0)
            {
                for (int i = 0; i < playerPoints.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells", i + 1, playerPoints[i].Name, playerPoints[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty highscore!\n");
            }
        }

        private static void NextToMove(char[,] field, char[,] mines, int row, int colum)
        {
            char numberOfMines = CountMines(mines, row, colum);
            mines[row, colum] = numberOfMines;
            field[row, colum] = numberOfMines;
        }

        private static void DrawBoard(char[,] board)
        {
            int rows = board.GetLength(0);
            int colums = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < colums; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateMineField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceMines()
        {
            int rows = 5;
            int colums = 10;
            int numberOfMines = 15;

            char[,] playField = new char[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    playField[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();

            while (mines.Count < numberOfMines)
            {
                Random random = new Random();
                int newMine = random.Next(50);
                if (!mines.Contains(newMine))
                {
                    mines.Add(newMine);
                }
            }

            foreach (int mine in mines)
            {
                int colum = mine / colums;
                int row = mine % colums;
                if (row == 0 && mine != 0)
                {
                    colum--;
                    row = colums;
                }
                else
                {
                    row++;
                }

                playField[colum, row - 1] = '*';
            }

            return playField;
        }

        private static void CalculateMines(char[,] field)
        {
            int colum = field.GetLength(0);
            int row = field.GetLength(1);

            for (int i = 0; i < colum; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char minesCounter = CountMines(field, i, j);
                        field[i, j] = minesCounter;
                    }
                }
            }
        }

        private static char CountMines(char[,] field, int currentRow, int currentColum)
        {
            int minesCounter = 0;
            int rows = field.GetLength(0);
            int colums = field.GetLength(1);

            if (currentRow - 1 >= 0)
            {
                if (field[currentRow - 1, currentColum] == '*')
                {
                    minesCounter++;
                }
            }

            if (currentRow + 1 < rows)
            {
                if (field[currentRow + 1, currentColum] == '*')
                {
                    minesCounter++;
                }
            }

            if (currentColum - 1 >= 0)
            {
                if (field[currentRow, currentColum - 1] == '*')
                {
                    minesCounter++;
                }
            }

            if (currentColum + 1 < colums)
            {
                if (field[currentRow, currentColum + 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentColum - 1 >= 0))
            {
                if (field[currentRow - 1, currentColum - 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentColum + 1 < colums))
            {
                if (field[currentRow - 1, currentColum + 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((currentRow + 1 < rows) && (currentColum - 1 >= 0))
            {
                if (field[currentRow + 1, currentColum - 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((currentRow + 1 < rows) && (currentColum + 1 < colums))
            {
                if (field[currentRow + 1, currentColum + 1] == '*')
                {
                    minesCounter++;
                }
            }

            return char.Parse(minesCounter.ToString());
        }
    }
}