using System;

namespace Demo
{
    class StartUp
    {
        static void Main(string[] args)
        {

            Family family = new Family();
            int count = int.Parse(Console.ReadLine());


            for (int i = 0; i < count; i++)
            {
                string[] peopleProps = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(peopleProps[0], int.Parse(peopleProps[1]));
                family.AddMember
            }
        }
    }
}
