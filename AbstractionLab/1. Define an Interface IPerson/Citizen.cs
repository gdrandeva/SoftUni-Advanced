using System;
using System.Collections.Generic;
using System.Text;


namespace PersonInfo
{
    public class Citizen : IPerson, IIdentifiable,IBirthable
    {
        private string name;
        private int age;

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
           // this.Birthdate = birthdate;
        }

        public string Name
        { 
        get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) )
                {
                    throw new ArgumentException("Null cannot be null or whitespace!");
                }
                this.name = value;
            }
        
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Age cannot be null or negative value!");
                }
                this.age = value;
            }

        }

        public string Id { get; private set; }

        public string Birthdate { get; private set; }
    }
}
