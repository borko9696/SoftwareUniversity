using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Football_League.Models;

namespace Football_League
{
    public class LeagueManager
    {
        
        public static void HandleInput(string input)
        {
            var inputArgs = input.Split();
            switch (inputArgs[0])
            {
                case "AddTeam":
                    League.AddTeam(new Team(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3])));
                    break;
                case "AddMatch":
                    var homeTeam = League.Teams.First(t => t.Name == inputArgs[2]);
                    var awayTeam = League.Teams.First(t => t.Name == inputArgs[3]);

                    League.AddMatch(new Match(homeTeam, awayTeam, new Score(int.Parse(inputArgs[4]), int.Parse(inputArgs[5])), int.Parse(inputArgs[1])));
                    break;
                case "AddPlayerToTeam":
                    var team = League.Teams.First(t => t.Name == inputArgs[5]);

                    League.AddPlayerToTeam(new Player(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]), decimal.Parse(inputArgs[4]), team));
                    break;
                case "ListTeams":
                    foreach (var team1 in League.Teams)
                    {
                        Console.WriteLine(team1.ToString());
                    }
                    break;
                case "ListMatches":
                    foreach (var match in League.Matches)
                    {
                        Console.WriteLine(match.ToString());
                    }
                    break;
            }
        }
    }
}
