using System;
using System.Collections.Generic;

namespace ValidationData
{
    public class StartUp
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                try
                {
                    string[] cmdArgs = Console.ReadLine().Split();
                    Person person = new Person(cmdArgs[0],
                                            cmdArgs[1],
                                            int.Parse(cmdArgs[2]),
                                            double.Parse(cmdArgs[3]));
                    people.Add(person);
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); ;
                }
            }

            double bonus = double.Parse(Console.ReadLine());
            people.ForEach(p => p.IncreaseSalary(bonus));
            people.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
