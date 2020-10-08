using ShoppingSpree.Common;
using System;

namespace ShoppingSpree.Models
{
    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string name,decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidNameExceptionMessage);
                }
                this.name = value;
            }
        }

        public decimal Cost
        {
            get
            {
                return this.cost;
            }
            private set
            {
                if (value <= GlobalConstants.MIN_COST)
                {
                    throw new ArgumentException(GlobalConstants.InvalidCostInputExceptionMessage);
                }

                this.cost = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
