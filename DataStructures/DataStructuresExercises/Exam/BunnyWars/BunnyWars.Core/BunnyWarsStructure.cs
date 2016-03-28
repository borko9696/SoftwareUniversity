namespace BunnyWars.Core
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Wintellect.PowerCollections;

    #endregion

    public class BunnyWarsStructure : IBunnyWarsStructure
    {
        private readonly OrderedDictionary<string, Bunny> bunnies = new OrderedDictionary<string, Bunny>();

        private readonly Dictionary<int, SortedSet<Bunny>> bunniesByTeam = new Dictionary<int, SortedSet<Bunny>>();

        private readonly List<int> rooms = new List<int>();

        private readonly OrderedDictionary<int, OrderedDictionary<int, SortedSet<Bunny>>> roomsWithBunnies =
            new OrderedDictionary<int, OrderedDictionary<int, SortedSet<Bunny>>>();

        public int BunnyCount
        {
            get
            {
                return this.bunnies.Count;
            }
        }

        public int RoomCount
        {
            get
            {
                return this.roomsWithBunnies.Count;
            }
        }

        public void AddBunny(string name, int team, int roomId)
        {
            var bunny = new Bunny(name, team, roomId);
            if (!this.roomsWithBunnies.ContainsKey(roomId))
            {
                throw new ArgumentException();
            }

            if (team < 0 || team > 4)
            {
                throw new IndexOutOfRangeException();
            }

            if (this.bunnies.ContainsKey(name))
            {
                throw new ArgumentException();
            }

            this.bunnies[name] = bunny;

            if (!this.roomsWithBunnies[roomId].ContainsKey(team))
            {
                this.roomsWithBunnies[roomId][team] = new SortedSet<Bunny>();
            }

            this.roomsWithBunnies[roomId][team].Add(bunny);

            if (!this.bunniesByTeam.ContainsKey(team))
            {
                this.bunniesByTeam[team] = new SortedSet<Bunny>();
            }

            this.bunniesByTeam[team].Add(bunny);
        }

        public void AddRoom(int roomId)
        {
            if (this.roomsWithBunnies.ContainsKey(roomId))
            {
                throw new ArgumentException("Room with this this ID already exsist");
            }

            this.roomsWithBunnies[roomId] = new OrderedDictionary<int, SortedSet<Bunny>>();

            this.rooms.Add(roomId);
        }

        public void Detonate(string bunnyName)
        {
            if (!this.bunnies.ContainsKey(bunnyName))
            {
                throw new ArgumentException();
            }

            var detonator = this.bunnies[bunnyName];

            var roomWithDetonator = this.roomsWithBunnies[detonator.RoomId];
            var otherTeams = roomWithDetonator.Where(t => t.Key != detonator.Team);

            var targetBunnys = new List<Bunny>();
            targetBunnys.AddRange(otherTeams.SelectMany(b => b.Value));

            foreach (var bunny in targetBunnys)
            {
                bunny.Health -= 30;
                if (bunny.Health <= 0)
                {
                    this.bunnies.Remove(bunny.Name);
                    this.bunniesByTeam[bunny.Team].Remove(bunny);
                    this.roomsWithBunnies[bunny.RoomId][bunny.Team].Remove(bunny);
                    detonator.Score++;
                }
            }
        }

        public IEnumerable<Bunny> ListBunniesBySuffix(string suffix)
        {
            var result = this.bunnies.Range(suffix + char.MaxValue, true, suffix, true).Select(g => g.Value);

            return result;
        }

        public IEnumerable<Bunny> ListBunniesByTeam(int team)
        {
            if (team < 0 || team > 4)
            {
                throw new IndexOutOfRangeException();
            }

            if (!this.bunniesByTeam[team].Any())
            {
                return null;
            }

            return this.bunniesByTeam[team];
        }

        public void Next(string bunnyName)
        {
            if (!this.bunnies.ContainsKey(bunnyName))
            {
                throw new ArgumentException();
            }

            var firstRoom = this.rooms[0];
            var lastRoom = this.rooms[this.rooms.Count - 1];

            var bunny = this.bunnies[bunnyName];

            if (bunny.RoomId == lastRoom)
            {
                bunny.RoomId = firstRoom;

                if (!this.roomsWithBunnies[firstRoom].ContainsKey(bunny.Team))
                {
                    this.roomsWithBunnies[firstRoom][bunny.Team] = new SortedSet<Bunny>();
                }

                this.roomsWithBunnies[firstRoom][bunny.Team].Add(bunny);
            }
            else
            {
                var currentRoomId = this.rooms.IndexOf(bunny.RoomId);
                var nextRoom = this.rooms[currentRoomId + 1];
                bunny.RoomId = nextRoom;

                if (!this.roomsWithBunnies[nextRoom].ContainsKey(bunny.Team))
                {
                    this.roomsWithBunnies[nextRoom][bunny.Team] = new SortedSet<Bunny>();
                }

                this.roomsWithBunnies[nextRoom][bunny.Team].Add(bunny);
            }

            this.roomsWithBunnies[bunny.RoomId][bunny.Team].Remove(bunny);
        }

        public void Previous(string bunnyName)
        {
            if (!this.bunnies.ContainsKey(bunnyName))
            {
                throw new ArgumentException();
            }

            var firstRoom = this.rooms[0];
            var lastRoom = this.rooms[this.rooms.Count - 1];

            var bunny = this.bunnies[bunnyName];

            if (bunny.RoomId == firstRoom)
            {
                bunny.RoomId = lastRoom;

                if (!this.roomsWithBunnies[lastRoom].ContainsKey(bunny.Team))
                {
                    this.roomsWithBunnies[lastRoom][bunny.Team] = new SortedSet<Bunny>();
                }

                this.roomsWithBunnies[lastRoom][bunny.Team].Add(bunny);
            }
            else
            {
                var currentRoomId = this.rooms.IndexOf(bunny.RoomId);
                var prevRoom = this.rooms[currentRoomId - 1];
                bunny.RoomId = prevRoom;
                if (!this.roomsWithBunnies[prevRoom].ContainsKey(bunny.Team))
                {
                    this.roomsWithBunnies[prevRoom][bunny.Team] = new SortedSet<Bunny>();
                }

                this.roomsWithBunnies[prevRoom][bunny.Team].Add(bunny);
            }

            this.roomsWithBunnies[bunny.RoomId][bunny.Team].Remove(bunny);
        }

        public void Remove(int roomId)
        {
            if (!this.roomsWithBunnies.ContainsKey(roomId))
            {
                throw new ArgumentException();
            }

            var collectionWithBunniesToRemove = this.roomsWithBunnies[roomId].SelectMany(b => b.Value);

            foreach (var bunny in collectionWithBunniesToRemove)
            {
                this.bunnies.Remove(bunny.Name);
                this.bunniesByTeam[bunny.Team].Remove(bunny);
            }

            this.roomsWithBunnies.Remove(roomId);
        }
    }
}