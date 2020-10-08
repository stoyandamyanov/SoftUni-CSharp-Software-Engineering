using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;



        public string Name
        {
            get { return name; }
            set { name = Name; }
        }

        public int Age
        {
            get { return age; }
            set { age = Age; }
        }

        public Person () : this("No name", 1)
        {
           
        }

        public Person(int A) : this("No name",A)
        {
           
        }

        public Person(string Name,int Age)
        {
            name = Name;
            age = Age;
        }
    }
}
