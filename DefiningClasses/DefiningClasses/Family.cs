using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private readonly HashSet<Person> members;

        public Family()
        {
            this.members = new HashSet<Person>();
        }

        public void AddMemeber(Person member)
        {
            this.members.Add(member);
        }

        public Person GetOldestMember()
            => this.members.OrderByDescending(p => p.Age).FirstOrDefault();

        public HashSet<Person> GetAllAbove30()
            => this.members
            .Where(n => n.Age > 30)
            .OrderBy(n => n.Name)
            .ToHashSet();
    }
}
