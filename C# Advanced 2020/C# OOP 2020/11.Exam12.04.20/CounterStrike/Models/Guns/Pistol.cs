using System;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Models.Guns
{
    public class Pistol : Gun
    {
        private const int firedBullets = 1;
        public Pistol(string name, int bulletsCount)
            : base(name, bulletsCount)
        {

        }

        public override int Fire()
        {
            if (this.BulletsCount - firedBullets >= 0)
            {
                this.BulletsCount -= firedBullets;
                return firedBullets;
            }

            return 0;
        }
    }
}
