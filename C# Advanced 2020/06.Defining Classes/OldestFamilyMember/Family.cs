using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OldestFamilyMember
{
    public class Family
    {
        private readonly HashSet<Person> Members;

        public Family()
        {
            this.Members = new HashSet<Person>();
        }

        public void AddMember(Person member)
        {
            this.Members.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldestPerson = this.Members
                .OrderByDescending(p => p.Age)
                .FirstOrDefault();

            return oldestPerson;
        }
    }
}
