using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Guns
{
    public class Pistol : Gun
    {
        private const int bulletsBarrel = 10;
        private const int totalBullets = 100;
        private const int pistolDamage = 1;
        public Pistol(string name) 
            : base(name, bulletsBarrel, totalBullets)
        {
        }

        public override int Fire()
        {
            if(this.BulletsPerBarrel - pistolDamage <= 0 && this.TotalBullets > 0)
            {
                this.BulletsPerBarrel--;
                this.BulletsPerBarrel = bulletsBarrel;
                this.TotalBullets -= bulletsBarrel;
                return pistolDamage;
            }
            if (this.CanFire == true)
            {
                this.BulletsPerBarrel--;
                return pistolDamage;
            }

            return 0;
        }
    }
}
