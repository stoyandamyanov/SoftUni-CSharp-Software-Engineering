using System;

namespace PizzaCalories
{
   public class Dough
    {
        private const string firstType = "white";
        private const string secondType = "wholegrain";

        
        private string flourType;
        private string bakingTech;
        private double weight;


        public Dough(string flourType, string bakingTech, double weight)
            
        {
            this.FlourType = flourType;
            this.BakingTech = bakingTech;
            this.Weight = weight;

        }


        public string FlourType
        {
            get
            {
                return this.flourType;
            }
            private set
            {

                if(value.ToLower() != firstType && value.ToLower() != secondType)
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public string BakingTech
        {
            get
            {
                return this.bakingTech;
            }
            private set
            {
                if(value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTech = value;
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
                if(value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        public double CalculateCalories()
        {
            double calories = 2 * weight;

            if(FlourType.ToLower() == "white")
            {
                calories *= 1.5;
            }
            else if (FlourType.ToLower() == "wholegrain")
            {
                calories *= 1.0;
            }

            if(BakingTech.ToLower() == "crispy")
            {
                calories *= 0.9;
            }
            else if(BakingTech.ToLower() == "chewy")
            {
                calories *= 1.1;
            }
            else if(BakingTech.ToLower() == "homemade")
            {
                calories *= 1.0;
            }

            return calories;
        }
    }
}
