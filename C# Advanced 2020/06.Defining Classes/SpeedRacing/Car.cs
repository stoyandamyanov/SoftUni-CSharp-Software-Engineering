using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public string model;
        public double fuelAmount;
        public double fuelConsumptionPerkm;
        public int travelledDistance;

        public Car(string Model, double FuelAmount, double FuelConsumpPerKM)
        {
            this.model = Model;
            this.fuelAmount = FuelAmount;
            this.fuelConsumptionPerkm = FuelConsumpPerKM;

        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public double FuelConsumptionPerkm
        {
            get { return this.fuelConsumptionPerkm; }
            set { this.fuelConsumptionPerkm = value; }
        }

        public int TravelledDistance
        {
            get { return this.travelledDistance; }
            set { this.travelledDistance = value; }
        }

        public bool Drive(int distance)
        {
            if (distance * FuelConsumptionPerkm <= FuelAmount)
            {
                FuelAmount -= FuelConsumptionPerkm * distance;
                TravelledDistance += distance;
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:F2} {TravelledDistance}";
        }




    }
}
