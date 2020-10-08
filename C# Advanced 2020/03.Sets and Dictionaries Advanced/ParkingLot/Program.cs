using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine()
                .Split(", ");

            var carsIn = new HashSet<string>();

            while (command[0] != "END")
            {
                if(command[0] == "IN")
                {
                    string car = command[1];

                    carsIn.Add(car);
                }
                else if(command[0] == "OUT")
                {
                    string car = command[1];

                    if(carsIn.Contains(car))
                    {
                        carsIn.Remove(car);
                    }
                }
                
                
                
                command = Console.ReadLine()
                    .Split(", ");
            }

            if(carsIn.Count >= 1)
            {
                foreach (var Car in carsIn)
                {
                    Console.WriteLine(Car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
