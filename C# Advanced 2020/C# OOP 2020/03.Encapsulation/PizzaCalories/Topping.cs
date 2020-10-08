using System;

namespace PizzaCalories
{
    public class Topping
    {
        private const string INVALID_TYPE_EXCEPTION_MESSAGE = "Cannot place {0} on top of your pizza.";
        private const string INVALID_WEIGHT_EXCEPTION_MESSAGE = "{0} weight should be in the range[1..50].";
        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;

        }

        public string Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                if(value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException(String.Format(INVALID_TYPE_EXCEPTION_MESSAGE, value));
                }
                this.type = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if(value < 1 || value > 50)
                {
                    throw new ArgumentException(String.Format(INVALID_WEIGHT_EXCEPTION_MESSAGE, this.type));
                }
                this.weight = value;
            }
        }

        public double CalculateToppingCalories()
        {
            double calories = 0.0;

            switch (this.type.ToLower())
            {
                case "meat": calories = 2 * this.Weight * 1.2; break;
                case "veggies": calories = 2 * this.Weight * 0.8; break;
                case "cheese": calories = 2 * this.Weight * 1.1; break;
                case "sauce": calories = 2 * this.Weight * 0.9; break;
                default:
                    break;
            }

            return calories;
        }
    }
}
