using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basketball
{
    public class Team
    {
        private List<Player> players;

        public Team(string name, int openPositions, char group)
        {
            players = new List<Player>();

            Name = name;
            OpenPositions = openPositions;
            Group = group;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int openPositions;

        public int OpenPositions
        {
            get { return openPositions; }
            set { openPositions = value; }
        }

        private char group;

        public char Group
        {
            get { return group; }
            set { group = value; }
        }

        public int Count { get { return players.Count; } }

        public string AddPlayer(Player player)
        {
            if (String.IsNullOrEmpty(player.Name) || String.IsNullOrEmpty(player.Position))
            {
                return "Invalid player's information.";
            }
            if (OpenPositions==0)
            {
                return "There are no more open positions." ;
            }
            if (player.Rating<80)
            {
                return "Invalid player's rating.";
            }
            players.Add(player);
            OpenPositions--;
            return $"Successfully added {player.Name} to the team. Remaining open positions: {OpenPositions}.";
        }

        public bool RemovePlayer(string name)
        {
            Player player = players.Find(n => n.Name == name);
            if (players.Contains(player))
            {
                players.Remove(player);
                OpenPositions--;
                return true;
            }
            return false;
        
        }

        public int RemovePlayerByPosition(string position)
        {
            List<Player> removedPlayers = new List<Player>();
            Player player = players.FirstOrDefault(p => p.Position == position);
            if (players.Contains(player))
            {
                while (players.Contains(player))
                {
                    
                    players.Remove(player);
                    removedPlayers.Add(player);
                    OpenPositions--;
                    player = players.FirstOrDefault(p => p.Position == position);
                }
                
                
                return removedPlayers.Count;
            }
            return 0;
        }
         
        public Player RetirePlayer(string name)
        {
            Player player = players.Find(n => n.Name == name);
            if (players.Contains(player))
            {
                player.Retired = true;
                return player;
            }
            return null;
        
        }


        public List<Player> AwardPlayers(int games)
        {
            List<Player> participants = players.FindAll(g => g.Games >= games).ToList();
            return participants;
        
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Active players competing for Team {Name} from Group {Group}:");
            foreach (var person in players)
            {
                if (person.Retired==false)
                {
                    result.AppendLine(person.ToString());
                }
            }

            return result.ToString().Trim();
        
        
        }
    }
}
