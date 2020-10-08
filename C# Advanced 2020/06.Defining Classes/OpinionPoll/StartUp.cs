using System;
using System.Collections.Generic;

namespace OpinionPoll
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            AllPeople people = new AllPeople();

            for (int i = 0; i < n; i++)
            {
                string[] personArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string Name = personArgs[0];
                int Age = int.Parse(personArgs[1]);

                Person person = new Person(Name, Age);
                
                people.AddMember(person);

            }
            HashSet<Person> result = people.allPeopleover30();

            Console.WriteLine(string.Join(Environment.NewLine,result));
        }
    }
}
