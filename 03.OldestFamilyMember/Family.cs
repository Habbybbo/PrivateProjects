using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        
        public Dictionary<string, int> FamilyMembers { get; set; }

        public Family()
        {

        }
        public Family(string name, int age)
        {

        }

        public void AddMember(Person member)
        {
            FamilyMembers.Add(member.Name, member.Age);

        }

        public Person GetOldestMember()
        {
            Person oldestMember = new Person();

            foreach (var person in FamilyMembers)
            {
                if (person.Value >= oldestMember.Age)
                {
                    oldestMember.Name = person.Key;
                    oldestMember.Age = person.Value;
                }
            }

            return oldestMember;
        }
    }
}
