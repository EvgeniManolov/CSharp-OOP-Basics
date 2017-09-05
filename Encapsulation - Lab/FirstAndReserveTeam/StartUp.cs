﻿using System;
using System.Collections.Generic;

namespace FirstAndReserveTeam
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                Person person = new Person(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        double.Parse(cmdArgs[3]));

                people.Add(person);
            }

            double bonus = double.Parse(Console.ReadLine());
            people.ForEach(p => p.IncreaseSalary(bonus));
            Console.WriteLine();
        }
    }
}
