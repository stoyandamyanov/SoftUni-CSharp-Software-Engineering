using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Utilities.Messages;

namespace ViceCity.Models.Guns
{
    public abstract class Gun : IGun
    {
        private string name;
        private int bulletsPerBarrel;
        private int totalbullets;

        protected Gun(string name,int bulletsperbarrel,int totalbullets)
        {
            this.Name = name;
            this.BulletsPerBarrel = bulletsperbarrel;
            this.TotalBullets = totalbullets;
        }

        public string Name 
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGunName);
                }
                this.name = value;
            }
        }
        public int BulletsPerBarrel
        {
            get
            {
                return this.bulletsPerBarrel;
            }
            protected set
            {
                if(value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidBulletsPerBarrel);
                }

                this.bulletsPerBarrel = value;
            }
        }

        public int TotalBullets
        {
            get
            {
                return this.totalbullets;
            }
            protected set
            {
                if(value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidTotalBulletsCount);
                }
                this.totalbullets = value;
            }
        }
        public bool CanFire => this.BulletsPerBarrel > 0;

        public abstract int Fire();
    }
}
