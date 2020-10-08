using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Guns
{
    public class Rifle : Gun
    {
        private const int bulletsPerBarrel = 50;
        private const int totalBullets = 500;
        private const int rifleDamage = 5;
        public Rifle(string name) 
            : base(name, bulletsPerBarrel, totalBullets)
        {
        }

        public override int Fire()
        {
            if(this.BulletsPerBarrel - rifleDamage <= 0 && this.TotalBullets > 0)
            {
                this.BulletsPerBarrel -= rifleDamage;
                this.BulletsPerBarrel = bulletsPerBarrel;
                this.TotalBullets -= bulletsPerBarrel;
                return rifleDamage;
            }

            if(this.CanFire == true)
            {
                this.BulletsPerBarrel -= rifleDamage;
                return rifleDamage;
            }

            return 0;
        }
    }
}
