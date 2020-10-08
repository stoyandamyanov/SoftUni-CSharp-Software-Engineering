using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Robots
{
    public abstract class Robot : IRobot
    {
        private string name;
        private int happiness;
        private int energy;
        private int proceduretime;
        private string owner = "Service";


        public Robot(string name,int energy, int happiness,int proceduretime)
        {
            this.Name = name;
            this.Happiness = happiness;
            this.Energy = energy;
            this.ProcedureTime = proceduretime;
            this.IsBought = false;
            this.IsChipped = false;
            this.IsChecked = false;
            this.Owner = owner;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
            
        }

        public int Happiness
        {
            get
            {
                return this.happiness;
            }
            set
            {
                if(value < 0 && value > 100)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidHappiness);
                }

                this.happiness = value;
            }
        }

        public int Energy
        {
            get
            {
                return this.energy;
            }
            set
            {
                if (value < 0 && value > 100)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidEnergy);
                }

                this.energy = value;
            }
        }

        public int ProcedureTime
        {
            get
            {
                return this.proceduretime;
            }
            set
            {
                this.proceduretime = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }
        public bool IsBought { get; set; }
        public bool IsChipped { get; set; }
        public bool IsChecked { get; set; }

        public override string ToString()
        {
            return $" Robot type: {this.GetType().Name} - {this.name} - Happiness: {this.Happiness} - Energy: {this.Energy}";
        }
    }
}
