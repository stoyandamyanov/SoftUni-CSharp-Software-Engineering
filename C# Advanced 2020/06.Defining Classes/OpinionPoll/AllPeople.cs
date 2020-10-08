using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpinionPoll
{
    public class AllPeople
    {
        private readonly HashSet<Person> Members;

        public AllPeople()
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

        public HashSet<Person> allPeopleover30()
        {
            return this.Members
                .Where(p => p.Age > 30)
                .OrderBy(n => n.Name)
                .ToHashSet();

            
        }
    }
}
