using System;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Models.Guns
{
    public class Rifle : Gun
    {
        private const int firedBullets = 10;
        public Rifle(string name, int bulletsCount) 
            : base(name, bulletsCount)
        {
        }

        public override int Fire()
        {
            if(this.BulletsCount - firedBullets >= 0)
            {
                this.BulletsCount -= firedBullets;
                return firedBullets;
            }

            return 0;
        }
    }
}
