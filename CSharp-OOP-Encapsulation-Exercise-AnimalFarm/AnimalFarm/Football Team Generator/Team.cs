using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Football_Team_Generator
{
    public class Team
    {
        private string name;

        private List<Player> playerList;

        private Team()
        {
            this.playerList = new List<Player>();
        }

        public Team(string name)
            : this()
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameCannotBeNullOrWhiteSpace);
                }
                this.name = value;

            }
        }

        public int Rating
       => this.playerList.Count > 0 ?
            (int)Math.Round(this.playerList.Average(p => p.OverallRating), 0) : 0;



        public void AddPlayer(Player player)
        {
            this.playerList.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            Player playerToRemove = this.playerList
                .FirstOrDefault(p => p.Name == playerName);

            if (playerToRemove == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.MissingPlayerMessage, playerName, this.Name));
            }
            this.playerList.Remove(playerToRemove);
        }




    }
}
