using System;
using System.Linq;
using System.Collections.Generic;

namespace OpinionPoll
{
    public class StartUp
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                people.Add(new Person(tokens[0], int.Parse(tokens[1])));
            }

            foreach (Person person in people.Where(p => p.Age > 30).OrderBy(p => p.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
