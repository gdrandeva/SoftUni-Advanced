using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
           

            

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        
            Person person2 = new Person(20);
            Person person3 = new Person("Gosho",30);

            Console.WriteLine(person3.Name);
            Console.WriteLine(person3.Age);
        }
    }
}
