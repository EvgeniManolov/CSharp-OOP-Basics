using System;
using System.Reflection;

namespace OldestFamilyMember
{
    public class StartUp
    {
        public static void Main()
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");

            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            Family family = new Family();
            int people = int.Parse(Console.ReadLine());

            for (int i = 0; i < people; i++)
            {
                string[] tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                family.AddMember(new Person(tokens[0], int.Parse(tokens[1])));
            }

            Person oldestMember = family.GetOldestMember();
            Console.WriteLine("{0} {1}", oldestMember.Name, oldestMember.Age);
        }
    }
}
