using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
   public class Team
    {
        private string name;

        private List<Person> firstTeam;

        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.name = name;
        }

        public IReadOnlyCollection FirstTeam { get { return this.firstTeam.AsReadOnly(); } }

    }
}
