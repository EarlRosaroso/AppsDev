using System;
using System.Collections.Generic;

namespace PersonWeightTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            Console.WriteLine("Welcome to Person Weight Tracker!");

            bool addingPersons = true;
            while (addingPersons)
            {
                Console.WriteLine("\nEnter person details:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Weight: ");
                int weight = int.Parse(Console.ReadLine());

                Person person = new Person(name, weight);
                persons.Add(person);

                Console.Write("\nDo you want to add another person? (yes/no): ");
                string choice = Console.ReadLine().ToLower();
                addingPersons = choice == "yes";
            }

            Console.WriteLine("\nPersons added:");

            int totalWeight = 0;
            foreach (var person in persons)
            {
                Console.WriteLine($"Name: {person.Name}, Weight: {person.Weight}");
                totalWeight += person.Weight;
            }

            Console.WriteLine($"\nTotal weight of all persons: {totalWeight}");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public Person(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }
    }
}
