using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FamilyTree
{
    public class Program
    {
        public static void Main()
        {

            List<Person> people = new List<Person>();
            List<string> storePeople = new List<string>();

            string person = Console.ReadLine();
            string inputLine = Console.ReadLine();

            while (!inputLine.Equals("End"))
            {
                var info = Regex.Split(inputLine, " - ");

                if (info.Length == 1) // person and date
                {
                    int lastIndexOfSpace = inputLine.LastIndexOf(" ");

                    string name = inputLine.Substring(0, lastIndexOfSpace);
                    string birthday = inputLine.Substring(lastIndexOfSpace + 1);

                    Person newPerson = new Person(name, birthday);

                    people.Add(newPerson);
                }
                else
                {
                    storePeople.Add(inputLine);
                }

                inputLine = Console.ReadLine();
            }

            foreach (string storePerson in storePeople)
            {
                Person parent;
                Person children;

                string[] info = Regex.Split(storePerson, " - ");

                if (info[0].Contains('/') && info[1].Contains('/')) // only dates
                {
                    string parentBirhtday = info[0];
                    string childrenBirthday = info[1];

                    parent = people
                            .First(p => p.Birthday.Equals(parentBirhtday)); //  person in our list
                    children = people
                            .First(p => p.Birthday.Equals(childrenBirthday)); //  person in our list
                }
                else if (info[0].Contains('/') || info[1].Contains('/')) // only one date
                {
                    string name = string.Empty;
                    string birthday = string.Empty;

                    if (info[0].Contains('/')) // date
                    {
                        birthday = info[0];
                        name = info[1];

                        parent = people
                            .First(p => p.Birthday.Equals(birthday));
                        children = people
                            .First(p => p.Name.Equals(name));
                    }
                    else // Second is date
                    {
                        birthday = info[1];
                        name = info[0];

                        children = people
                            .First(p => p.Birthday.Equals(birthday));
                        parent = people
                            .First(p => p.Name.Equals(name));
                    }
                }
                else // Both are names
                {
                    string parentName = info[0];
                    string childrenName = info[1];

                    parent = people
                            .First(p => p.Name.Equals(parentName));
                    children = people
                            .First(p => p.Name.Equals(childrenName));
                }

                if (!parent.Children.Contains(children))
                {
                    parent.Children.Add(children);
                }

                if (!children.Parents.Contains(parent))
                {
                    children.Parents.Add(parent);
                }
            }

            Person ourPerson;

            // chech if searchPerson is date or Name
            if (person.Contains('/'))
            {
                ourPerson = people.First(p => p.Birthday.Equals(person));
            }
            else
            {
                ourPerson = people.First(p => p.Name.Equals(person));
            }

            StringBuilder result = new StringBuilder();

            result.AppendLine(ourPerson.ToString());

            result.AppendLine("Parents:");
            foreach (Person parent in ourPerson.Parents)
            {
                result.AppendLine(parent.ToString());
            }

            result.AppendLine("Children:");
            foreach (Person child in ourPerson.Children)
            {
                result.AppendLine(child.ToString());
            }

            Console.Write(result);
        }
    }
}
