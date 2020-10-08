using System;
using System.Collections.Generic;
using System.Text;

namespace OldestFamilyMember
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string Name,int Age)
        {
            name = Name;
            age = Age;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
