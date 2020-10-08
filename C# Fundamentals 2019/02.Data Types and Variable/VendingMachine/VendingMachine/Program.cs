using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double totalSum = 0;
            

            while (command != "Start")
            {
                double insertedCoins = double.Parse(command);

                if (insertedCoins != 0.1 && insertedCoins != 0.2 && insertedCoins != 0.5 && insertedCoins != 1 && insertedCoins != 2)
                {
                    Console.WriteLine($"Cannot accept {insertedCoins}");

                }
                else
                {
                    totalSum += insertedCoins;
                }

                command = Console.ReadLine();
            }
            double savedTotalSum = totalSum;
            string productType = " ";
            double Price = 0;
            double TotalPrice = 0;


            while (productType != "End")
            {
                productType = Console.ReadLine();
                switch (productType)
                {
                    case "Nuts":
                        Price = 2;
                        if(totalSum >= Price)
                        {
                            Console.WriteLine("Purchased nuts");
                            TotalPrice += Price;
                            totalSum -= Price;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                         Price = 0.7;
                        if(totalSum >= Price)
                        {
                            Console.WriteLine("Purchased water");
                            TotalPrice += Price;
                            totalSum -= Price;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        Price = 1.5;
                        if(totalSum >= Price)
                        {
                            Console.WriteLine("Purchased crisps");
                            TotalPrice += Price;
                            totalSum -= Price;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        Price = 0.8;
                        if (totalSum >= Price)
                        {
                            Console.WriteLine("Purchased soda");
                            TotalPrice += Price;
                            totalSum -= Price;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        Price = 1;
                        if(totalSum >= Price)
                        {
                            Console.WriteLine("Purchased coke");
                            TotalPrice += Price;
                            totalSum -= Price;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;

                        
                }
                if(productType != "Nuts" && productType != "Water" && productType != "Crisps" && productType != "Soda" && productType != "Coke" && productType != "End")
                {
                    Console.WriteLine("Invalid product");
                }
            }

            if(savedTotalSum >= TotalPrice)
            Console.WriteLine($"Change: {savedTotalSum-TotalPrice:f2}");
        }
    }
}
