﻿namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age)
            : base(name, age)
        {
            base.Age = age;
        }

        public override int Age 
        {
            get 
            {
                return base.Age;
            }
            protected set
            {
                if (value <= 15)
                {
                    base.Age = value;
                }
            }
        }
    }
}
