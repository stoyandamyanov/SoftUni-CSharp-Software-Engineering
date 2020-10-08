using RobotService.Models.Garages.Contracts;
using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Garages
{
    public class Garage : IGarage
    {
        private int capacity = 10;
        private Dictionary<string, IRobot> robots;
        public Garage()
        {
            this.robots = new Dictionary<string, IRobot>();
            this.Capacity = capacity;
        }
        public IReadOnlyDictionary<string, IRobot> Robots
            => this.robots;

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                this.capacity = value;
            }
        }
        public void Manufacture(IRobot robot)
        {
            if(this.robots.Count == this.Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);
            }
            if(this.robots.ContainsKey(robot.Name))
            {
                throw new ArgumentException(ExceptionMessages.ExistingRobot);
            }

            this.robots.Add(robot.Name, robot);
        }
        public void Sell(string robotName, string ownerName)
        {
            if (!this.robots.ContainsKey(robotName))
            {
                throw new ArgumentException(ExceptionMessages.InexistingRobot);
            }
            
            this.robots[robotName].Owner = ownerName;
            this.robots[robotName].IsBought = true;
            this.robots.Remove(robotName);
        }
    }
}
