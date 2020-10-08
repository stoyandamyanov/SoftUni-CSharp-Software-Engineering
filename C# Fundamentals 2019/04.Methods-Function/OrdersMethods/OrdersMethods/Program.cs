using System;

namespace OrdersMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string Product = Console.ReadLine();
            int Quantity = int.Parse(Console.ReadLine());

            Price(Product, Quantity);
        }
        static void Price(string type, int b)
        {
            double totalPrice = 0;

            if (type == "coffee")
            {
                totalPrice = b * 1.50;
            }
            else if(type == "water")
            {
                totalPrice = b * 1;
            }
            else if(type =="coke")
            {
                totalPrice = b * 1.40;
            }
            else if(type == "snacks")
            {
                totalPrice = b * 2;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
