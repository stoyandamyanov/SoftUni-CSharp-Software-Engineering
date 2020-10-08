using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var CompanyUsers = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ");

                string companyName = input[0];
                if(companyName == "End")
                {
                    break;
                }

                if(!CompanyUsers.ContainsKey(companyName))
                {
                    string companyUser = input[1];

                    CompanyUsers.Add(companyName, new List<string>());
                    CompanyUsers[companyName].Add(companyUser);
                }
                else if(CompanyUsers.ContainsKey(companyName) && !CompanyUsers[companyName].Contains(input[1]))
                {
                    string companyUser = input[1];
                    CompanyUsers[companyName].Add(companyUser);
                }
                
            }
            foreach (var company in CompanyUsers.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{company.Key}");
                foreach (var user in company.Value)
                {
                    Console.WriteLine($"-- {user}");
                }
            }
        }
    }
}
