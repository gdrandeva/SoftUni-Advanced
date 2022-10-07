using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            List<Person> listOfPeople = new List<Person>();

            int numberOfPeople = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(command[0], int.Parse(command[1]));

                if (person.Age > 30)
                {
                    listOfPeople.Add(person);
                }
            }

            foreach (var pson in listOfPeople.OrderBy(n => n.Name))
            {
                Console.WriteLine($"{pson.Name} - {pson.Age}");
            }


        }
    }
}