using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string guest = Console.ReadLine();

            var VIPList = new HashSet<string>();
            var RegularList = new HashSet<string>();

            while (guest != "PARTY")
            {
                char firstChar = guest[0];
                
                if(Char.IsDigit(firstChar))
                {
                    VIPList.Add(guest);
                }
                else
                {
                    RegularList.Add(guest);
                }
               


                guest = Console.ReadLine();
            }

            while (guest != "END")
            {
                char firstChar = guest[0];

                if (Char.IsDigit(firstChar))
                {
                    VIPList.Remove(guest);
                }
                else
                {
                    RegularList.Remove(guest);
                }



                guest = Console.ReadLine();
            }

            int totalCount = VIPList.Count + RegularList.Count;
            
            Console.WriteLine(totalCount);

            foreach (var Guest in VIPList)
            {
                Console.WriteLine(Guest);
            }

            foreach (var Guest in RegularList)
            {
                Console.WriteLine(Guest);
            }

        }
    }
}
