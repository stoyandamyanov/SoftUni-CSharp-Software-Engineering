using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Players.Contracts;
using ViceCity.Repositories;
using ViceCity.Repositories.Contracts;
using ViceCity.Utilities.Messages;

namespace ViceCity.Models.Players
{
    public abstract class Player : IPlayer
    {
        private string name;
        private int lifepoints;

        public Player(string name,int lifepoints)
        {
            this.Name = name;
            this.LifePoints = lifepoints;
            this.IsAlive = true;
            this.GunRepository = new GunRepository();
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
                    throw new ArgumentNullException(ExceptionMessages.InvalidPlayerName);
                }

                this.name = value;
            }
        }

        public bool IsAlive { get; private set; }
         

        public IRepository<IGun> GunRepository { get; private set; }

        public int LifePoints
        {
            get
            {
                return this.lifepoints;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerLifePoints);
                }

                this.lifepoints = value;
            }
        }

        public void TakeLifePoints(int points)
        {
            if (this.LifePoints - points <= 0)
            {
                this.LifePoints = 0;
                this.IsAlive = false;
            }
            else
            {
                this.LifePoints -= points;
            }
        }
    }
}
