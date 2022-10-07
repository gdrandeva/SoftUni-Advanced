using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
   public class Family
    {
        public Family()
        {
            People = new List<Person>();
        }

        public List<Person> People { get; set; }


        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public Person GetOldestMember(Person member)
        {
            return People
                .OrderByDescending(p => p.Age)
                .FirstOrDefault();
        }
    }
}
