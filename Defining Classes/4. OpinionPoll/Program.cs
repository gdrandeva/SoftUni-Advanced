using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> listOfPeople = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] personalInfo = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(personalInfo[0], int.Parse(personalInfo[1]));
                listOfPeople.Add(person);
            }

            foreach (var person in listOfPeople.OrderBy(n => n.Name))
            {
                if (person.Age>30)
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
            }
        }
    }
}
