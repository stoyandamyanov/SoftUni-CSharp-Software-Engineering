using System;

namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double FUEL_CONSUMPTION_INCREMENT = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption,double tankCapacity)
            : base(fuelQuantity, fuelConsumption,tankCapacity)
        {

        }

        public override double FuelConsumption
        {
            get
            {
                return base.FuelConsumption;
            }
            protected set
            {
                base.FuelConsumption = value + FUEL_CONSUMPTION_INCREMENT;
            }
        }

        //public override void Refuel(double fuelAmount)
        //{
            
        //    if(fuelAmount + FuelQuantity > TankCapacity)
        //    {
        //        throw new InvalidOperationException(String.Format("Cannot fit {0} fuel in the tank.", fuelAmount));
        //    }
        //    else
        //    {
        //        base.Refuel(fuelAmount);
        //    }
        //}
    }
}
