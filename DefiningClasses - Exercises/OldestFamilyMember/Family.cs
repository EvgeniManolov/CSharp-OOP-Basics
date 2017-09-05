using System.Linq;
using System.Collections.Generic;

namespace OldestFamilyMember
{
    public class Family
    {
        private List<Person> family;

        public Family()
        {
            this.Familyy = new List<Person>();
        }

        public List<Person> Familyy
        {
            get { return this.family; }
            private set { this.family = value; }
        }

        public void AddMember(Person member)
        {
            this.Familyy.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.Familyy.OrderByDescending(p => p.Age).First();
        }
    }
}
