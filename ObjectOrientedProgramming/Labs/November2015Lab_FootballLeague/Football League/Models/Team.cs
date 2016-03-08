using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_League.Models
{
    public class Team
    {
        private string name;
        private string nickname;
        private DateTime dateFounded;
        private List<Player> players;

        public Team(string name, string nickname, DateTime dateFounded)
        {
            this.Name = name;
            this.Nickname = name;
            this.DateFounded = dateFounded;
            this.players = new List<Player>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("Name should be more than 3 characters.");
                }
                this.name = value;
            }
        }

        public string Nickname
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("Name should be more than 3 characters.");
                }
                this.nickname = value;
            }
        }

        public DateTime DateFounded
        {
            get { return this.dateFounded; }
            set
            {
                if (value.Year < 1850)
                {
                    throw new ArgumentOutOfRangeException("Year of foundation must be after 1850's");
                }
                this.dateFounded = value;
            }
        }

        public IEnumerable<Player> Players
        {
            get { return this.players; }
        }

        public void AddPlayer(Player player)
        {
            if (CheckIfPlayerExist(player))
            {
                throw new InvalidOperationException("Player already exist for that team.");
            }
            this.players.Add(player);
        }

        public bool CheckIfPlayerExist(Player player)
        {
            return this.players.Any(ime => ime.FirstName == player.FirstName &&
                                         ime.LastName == player.LastName);
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Nickname: {1}, Date of Foundation: {2}", name, nickname, dateFounded);
        }
    }
}
