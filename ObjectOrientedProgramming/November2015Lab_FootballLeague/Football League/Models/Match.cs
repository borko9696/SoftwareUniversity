using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Football_League.Models
{
    public class Match
    {
        private Team homeTeam;
        private Team awayTeam;
        private Score score;
        private int id;

        //TODO: Create properties for the fields and initialize them from a constructor.

        public Match(Team homeTeam, Team awayTeam, Score score, int id)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.Score = score;
            this.Id = id;
        }
        public Team HomeTeam
        {
            get { return this.homeTeam; }
            set
            {
                if (value == awayTeam)
                {
                    throw new ArgumentException("Teams should be with different names.");
                }
                this.homeTeam = value;
            }
        }

        public Team AwayTeam
        {
            get { return this.awayTeam; }
            set
            {
                if (value == homeTeam)
                {
                    throw new ArgumentException("Teams should be with different names.");
                }
                this.awayTeam = value;
            }
        }

        public Score Score
        {
            get { return this.score; }
            set { this.score = value; }
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public Team GetWinner()
        {
            if (this.IsDraw())
            {
                return null;
            }
            return this.Score.HomeTeamGoals > this.Score.AwayTeamGoals ? this.HomeTeam : this.AwayTeam;
        }

        public bool IsDraw()
        {
            return this.Score.HomeTeamGoals == this.Score.AwayTeamGoals;
        }

        public override string ToString()
        {
            return string.Format("Hometeam: {0}, Awayteam: {1}, Score: {2}, Match ID: {3}", this.HomeTeam, this.AwayTeam, this.Score,
                this.Id);
        }
    }
}
