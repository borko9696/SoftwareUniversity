namespace _03.Football_League
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    #endregion

    class FootballLeague
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            var input = Console.ReadLine();

            var board = new Dictionary<string, int>();
            var goalBoard = new Dictionary<string, long>();

            while (input != "final")
            {
                var home = string.Empty;
                var awey = string.Empty;
                var goalHome = 0;
                var goalAwey = 0;

                var indexHome = input.IndexOf(key, StringComparison.Ordinal) + key.Length;
                var indexHomeEnd = input.IndexOf(key, indexHome, StringComparison.Ordinal);

                for (int i = indexHome; i < indexHomeEnd; i++)
                {
                    home += input[i];
                }

                var indexAwey = input.IndexOf(key, indexHomeEnd + key.Length, StringComparison.Ordinal) + key.Length;
                var indexAweyEnd = input.IndexOf(key, indexAwey, StringComparison.Ordinal);
                for (int i = indexAwey; i < indexAweyEnd; i++)
                {
                    awey += input[i];
                }

                var homeToChar = home.ToCharArray().Reverse().ToArray();
                home = new string(homeToChar).ToUpper();
                var aweyToChat = awey.ToCharArray().Reverse().ToArray();
                awey = new string(aweyToChat).ToUpper();

                var match = Regex.Match(input, @"(\d+):(\d+)");
                goalHome = int.Parse(match.Groups[1].Value);
                goalAwey = int.Parse(match.Groups[2].Value);

                var homeTeam = new Team(home);
                var aweyTeam = new Team(awey);

                if (goalHome > goalAwey)
                {
                    if (!board.ContainsKey(home))
                    {
                        board[home] = 0;
                    }

                    board[home] += 3;
                    homeTeam.Goals += goalHome;

                    if (!board.ContainsKey(awey))
                    {
                        board[awey] = 0;
                    }

                    aweyTeam.Goals += goalAwey;
                }
                else if (goalHome < goalAwey)
                {
                    if (!board.ContainsKey(awey))
                    {
                        board[awey] = 0;
                    }

                    board[awey] += 3;
                    aweyTeam.Goals += goalAwey;

                    if (!board.ContainsKey(home))
                    {
                        board[home] = 0;
                    }

                    homeTeam.Goals += goalHome;
                }
                else
                {
                    if (!board.ContainsKey(home))
                    {
                        board[home] = 0;
                    }

                    board[home]++;
                    homeTeam.Goals += goalHome;

                    if (!board.ContainsKey(awey))
                    {
                        board[awey] = 0;
                    }

                    board[awey]++;
                    aweyTeam.Goals += goalAwey;
                }

                if (!goalBoard.ContainsKey(homeTeam.Name))
                {
                    goalBoard[homeTeam.Name] = 0;
                }

                goalBoard[homeTeam.Name] += homeTeam.Goals;

                if (!goalBoard.ContainsKey(aweyTeam.Name))
                {
                    goalBoard[aweyTeam.Name] = 0;
                }

                goalBoard[aweyTeam.Name] += aweyTeam.Goals;

                input = Console.ReadLine();
            }

            var sortedBoard = board.OrderByDescending(x => x.Value).ThenBy(y => y.Key);
            var sortedGoalTeams = goalBoard.OrderByDescending(x => x.Value).ThenBy(y => y.Key).Take(3);

            int count = 1;

            Console.WriteLine("League standings:");
            foreach (var team in sortedBoard)
            {
                Console.WriteLine("{0}. {1} {2}", count, team.Key, team.Value);
                count++;
            }

            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in sortedGoalTeams)
            {
                Console.WriteLine("- {0} -> {1}", team.Key, team.Value);
            }
        }
    }

    class Team
    {
        public Team(string name)
        {
            this.Name = name;
        }

        public int Goals { get; set; }

        public string Name { get; set; }
    }
}