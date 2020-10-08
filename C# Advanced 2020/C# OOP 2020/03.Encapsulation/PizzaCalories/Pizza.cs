using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    public class Pizza
    {
        private const int MinLenght = 1;
        private const int MaxLength = 15;
        private const int MinToppingCount = 0;
        private const int MaxToppingCount = 10;
        

        private string name;
        private Dough dough;

        private readonly List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;

            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (value.Length < MinLenght || value.Length > MaxLength)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }
        
        public Dough Dough
        {
            get
            {
                return this.dough;
            }
            private set
            {
                this.dough = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            if ( this.toppings.Count < MinToppingCount || this.toppings.Count >= MaxToppingCount)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this.toppings.Add(topping);
        }
        
        public override string ToString()
        {
            double calories = this.Dough.CalculateCalories() + this.toppings.Sum(t => t.CalculateToppingCalories());
            return $"{this.Name} - {calories:F2} Calories.";
        }
    }
}
