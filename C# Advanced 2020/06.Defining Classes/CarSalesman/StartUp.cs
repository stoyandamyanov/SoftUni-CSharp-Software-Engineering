﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            HashSet<Engine> engines = new HashSet<Engine>();
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] engineArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);


                Engine engine = null;

                string model = engineArgs[0];
                int power = int.Parse(engineArgs[1]);

                if(engineArgs.Length == 4)
                {
                    int displacement = int.Parse(engineArgs[2]);
                    string efficiency = engineArgs[3];

                    engine = new Engine(model, power, displacement, efficiency);

                }
                else if(engineArgs.Length == 3)
                {
                    int displacement;

                    bool isDisplacement = int.TryParse(engineArgs[2], out displacement);
                    if (isDisplacement)
                    {
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        string efficiency = engineArgs[2];

                        engine = new Engine(model, power, efficiency);
                    }
                }
                else if(engineArgs.Length == 2)
                {
                    engine = new Engine(model, power);
                }

                engines.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] carArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Car car = null;

                string model = carArgs[0];
                Engine engine = engines.First(e => e.Model == carArgs[1]);

                if(carArgs.Length == 2)
                {
                    car = new Car(model, engine);
                }
                else if(carArgs.Length == 3)
                {
                    int weight;
                    bool isWeight = int.TryParse(carArgs[2], out weight);

                    if (isWeight)
                    {
                        car = new Car(model, engine, weight);
                    }
                    else
                    {
                        car = new Car(model, engine, carArgs[2]);
                    }
                }
                else if(carArgs.Length == 4)
                {
                    int weight = int.Parse(carArgs[2]);
                    string color = carArgs[3];
                    car = new Car(model, engine, weight, color);
                }

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
