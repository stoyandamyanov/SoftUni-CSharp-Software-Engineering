using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            Person first = new Person();
            first.Name = "Ivan";
            first.Age = 22;

            Person second = new Person("Iva",22);

            Console.WriteLine($"{second.Name} {second.Age}");
        }
        
    }
}
