using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Common;
using Vehicles.Models.Contracts;

namespace Vehicles.Models
{
    public abstract class Vehicle : IDriveable, IRefuelable
    {
        
        public Vehicle(double fuelQuantity,double fuelConsumption, double tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
            if(FuelQuantity > TankCapacity)
            {
                FuelQuantity = 0;
            }
        }

        public double FuelQuantity { get; private set; }
        public virtual double FuelConsumption { get; protected set; }

        public double TankCapacity { get; private set; }

        public string Drive(double kilometers)
        {
            double fuelNeeded = kilometers * this.FuelConsumption;

            if(this.FuelQuantity < fuelNeeded)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.NOTENOUGHFUELEXP, this.GetType().Name));
            }

            this.FuelQuantity -= fuelNeeded;

            return $"{this.GetType().Name} travelled {kilometers} km";
        }

        public string DriveEmpty(double kilometers)
        {
            double fuelNeeded = kilometers * (this.FuelConsumption - 1.4);

            if (this.FuelQuantity < fuelNeeded)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.NOTENOUGHFUELEXP, this.GetType().Name));
            }

            this.FuelQuantity -= fuelNeeded;

            return $"{this.GetType().Name} travelled {kilometers} km";
        }

        public virtual void Refuel(double fuelAmount)
        {
            if (fuelAmount + FuelQuantity > TankCapacity)
            {
                throw new InvalidOperationException(String.Format("Cannot fit {0} fuel in the tank", fuelAmount));
            }
            if (fuelAmount > 0)
            {
                this.FuelQuantity += fuelAmount;
            }
            else if(fuelAmount <= 0)
            {
                throw new InvalidOperationException("Fuel must be a positive number");
            }

        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity :f2}";
        }
    }
}
