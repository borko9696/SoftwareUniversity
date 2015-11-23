using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Football_League.Models
{
    public static class League
    {
        private static List<Team> teams = new List<Team>(); 
        private static List<Match> matches = new List<Match>();
        private static List<Player> players = new List<Player>();

        public static IEnumerable<Team> Teams
        {
            get { return teams; }
        }

        public static IEnumerable<Match> Matches
        {
            get { return matches; }
        }

        public static void AddMatch(Match match)
        {
            if (CheckId(match))
            {
                throw new InvalidOperationException("There can be only one Id.");
            }
            matches.Add(match);
        }

        public static void AddTeam(Team team)
        {
            teams.Add(team);
        }
        private static bool CheckId(Match match)
        {
            return matches.Any(id => id.Id == match.Id);
        }

        public static void AddPlayerToTeam(Player player)
        {
            players.Add(player);
        }
    }
}
