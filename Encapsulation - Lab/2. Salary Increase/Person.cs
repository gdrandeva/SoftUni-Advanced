using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
   public class Person
    {
        public Person(string firstName, string lastNam, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastNam;
            Age = age;
            Salary = salary;
        }


        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Age { get; private set; }

        public decimal Salary { get; private set; }

        //public override string ToString()
        //{
        //    return $"{FirstName} {LastName} is {Age} years old.";
        //}

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (Age<30)
            {
                percentage /= 2;
            }
            Salary += Salary * percentage / 100;


        }
    }
}
