using System;

namespace PizzaCalories
{
    public class Engine
    {
        private Pizza pizza;

        public void Run()
        {
            int exceptionCount = 0;

            string[] pizzaArg = Console.ReadLine()
                .Split(" ");

            string pizzaName = pizzaArg[1];

            string[] DoughArg = Console.ReadLine()
                .Split(" ");

            string command = DoughArg[0];
            string FlourType = DoughArg[1];
            string BakingTech = DoughArg[2];
            double Weight = 0.0;
            
            if (DoughArg[3] != string.Empty)
            {
                Weight = double.Parse(DoughArg[3]);
            }

            try
            {
                Dough dough = new Dough(FlourType, BakingTech, Weight);

                pizza = new Pizza(pizzaName, dough);
            }
            catch (Exception e)
            {
                if (exceptionCount == 0)
                {
                    Console.WriteLine(e.Message);
                    exceptionCount++;
                }
            }

            string[] ToppingInput = Console.ReadLine()
                .Split(" ");

            string toppingType = "";
            double toppingWeight = 0.0;

            while (ToppingInput[0] != "END")
            {

                toppingType = ToppingInput[1];
                
                if (ToppingInput[2] != string.Empty)
                {
                    toppingWeight = double.Parse(ToppingInput[2]);
                }
                try
                {
                    Topping topping = new Topping(toppingType, toppingWeight);
                    pizza.AddTopping(topping);
                }
                catch (Exception ae)
                {
                    if (exceptionCount == 0)
                    {
                        Console.WriteLine(ae.Message);
                        exceptionCount++;
                    }

                }

                ToppingInput = Console.ReadLine()
                    .Split(" ");

            }

            if (exceptionCount == 0)
            {
                Console.WriteLine(pizza);
            }

        }

    }

}
