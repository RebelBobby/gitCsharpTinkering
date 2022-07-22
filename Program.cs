
using System;

namespace Nerd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections ");
            UseDictionary();

            static void UseDictionary(){

                Dictionary<string, Person> peopleA = new Dictionary<string, Person>();

                peopleA.Add("Bryon", new Person {FirstName = "Brian", LastName = "Student", Age =18 });
                peopleA.Add("Greg", new Person {FirstName = "Greg", LastName = "Student", Age =18 });
                peopleA.Add("Sayngeun", new Person {FirstName = "Sayngeun", LastName = "Student", Age =18 });

                Person greg = peopleA["Greg"];
                Console.WriteLine(greg);

                Dictionary<string, Person> peopleB = new Dictionary<string, Person>(){

                    { "Bryon", new Person {FirstName = "Bryon", LastName = "Student", Age =18 }},
                    { "Greg", new Person {FirstName = "Greg", LastName = "Student", Age =18 }},
                    { "Sayngeun", new Person {FirstName = "Sayngeun", LastName = "Student", Age =18 }}
                };

                Person sayngeun = peopleB["Sayngeun"];
                Console.WriteLine(sayngeun);

            }
/*
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
                }*/
        }

    }

}