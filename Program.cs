
using System;

namespace Nerd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections ");

            static void UseList()
            {
                List<Person> people = new List<Person>(){

                    new Person {FirstName = "Greg", LastName = "Student", Age =18 },
                    new Person {FirstName = "Nexus", LastName = "Student", Age =18 },
                    new Person {FirstName = "Joseph", LastName = "Student", Age =18 },
                    new Person {FirstName = "Art", LastName = "Student", Age =18 },
                    new Person {FirstName = "Juan", LastName = "Student", Age =18 }
                };

                Console.WriteLine("Items in list : {0}", people.Count);

                foreach (Person p in people)
                {
                    Console.WriteLine(p);
                }

                Console.WriteLine("\n ->Adding new person.");
                people.Insert(2, new Person { FirstName = "JJ", LastName = "Student, Age = 21" });
                Console.WriteLine("Items in list : {0}", people.Count);

                Person[] arrayOfPeople = people.ToArray();
                foreach (Person p in arrayOfPeople)
                {
                    Console.WriteLine("First Names: {0}", p.FirstName);
                }
            }

        }

    }
}