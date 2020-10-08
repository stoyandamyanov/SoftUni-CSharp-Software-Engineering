using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string Model = input[0];
                int fuelA = int.Parse(input[1]);
                double fuelperKM = double.Parse(input[2]);

                

                cars.Add(new Car(Model, fuelA, fuelperKM));
                
            }

            string[] command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (true)
            {
                if(command[0] == "End")
                {
                    break;
                }

                string model = command[1];
                int distance = int.Parse(command[2]);

                Car car = cars.First(c => c.Model == model);

                if (!car.Drive(distance))
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }


                command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            cars.ForEach(Console.WriteLine);


        }
    }
}
