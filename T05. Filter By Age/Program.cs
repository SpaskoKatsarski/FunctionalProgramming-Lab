using System;
using System.Collections.Generic;
using System.Linq;

namespace T05._Filter_By_Age
{
    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> people = ReadPeople(n);

            string condition = Console.ReadLine();
            int ageLimit = int.Parse(Console.ReadLine());

            Func<Person, bool> filter = CreatePersonFilter(condition, ageLimit);

            List<Person> matchingPeople = people.Where(filter).ToList();

            string outputFormat = Console.ReadLine();

            Action<Person> printPerson = CreatePersonPrinter(outputFormat);

            PrintPeople(matchingPeople, printPerson);
        }

        private static void PrintPeople(List<Person> matchingPeople, Action<Person> printPerson)
        {
            foreach (var person in matchingPeople)
            {
                printPerson(person);
            }
        }

        private static List<Person> ReadPeople(int peopleCount)
        {
            List<Person> people = new List<Person>();

            for (int i = 0; i < peopleCount; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                people.Add(new Person(name, age));
            }

            return people;
        }

        private static Func<Person, bool> CreatePersonFilter(string condition, int ageLimit)
        {
            if (condition == "older")
            {
                return p => p.Age > ageLimit;
            }

            if (condition == "younger")
            {
                return p => p.Age < ageLimit;
            }

            throw new ArgumentException($"Invalid filter: {condition} {ageLimit}");
        }

        private static Action<Person> CreatePersonPrinter(string outputFormat)
        {
            if (outputFormat == "name age")
            {
                return (Person p) => Console.WriteLine($"{p.Name} - {p.Age}");
            }

            if (outputFormat == "name")
            {
                return (Person p) => Console.WriteLine($"{p.Name}");
            }

            if (outputFormat == "age")
            {
                return (Person p) => Console.WriteLine($"{p.Age}");
            }

            throw new ArgumentException($"Invalid output format: {outputFormat}");
        }
    }
}
