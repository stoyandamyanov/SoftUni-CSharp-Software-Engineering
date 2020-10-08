using RobotService.Models.Garages;
using RobotService.Models.Garages.Contracts;
using RobotService.Models.Procedures;
using RobotService.Models.Procedures.Contracts;
using RobotService.Models.Robots;
using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotService.Core.Contracts
{
    public class Controller : IController
    {
        private IGarage garage;
        private IRobot robot;
        private IProcedure procedure;
        private Dictionary<string, List<IRobot>> robotswithprocedures;
        public Controller()
        {
            this.garage = new Garage();
            this.robotswithprocedures = new Dictionary<string, List<IRobot>>();
        }

        public string Manufacture(string robotType, string name, int energy, int happiness, int procedureTime)
        {
            if(robotType != nameof(HouseholdRobot) && robotType != nameof(PetRobot) && robotType != nameof(WalkerRobot))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InvalidRobotType,robotType));
            }

            if(robotType == nameof(HouseholdRobot))
            {
                if(energy < 0 || energy > 100)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidEnergy);
                }
                else if(happiness < 0 || happiness > 100)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidHappiness);
                }

                robot = new HouseholdRobot(name, energy, happiness, procedureTime);

                if(this.garage.Robots.Count == 10)
                {
                    throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);
                }
                else if (this.garage.Robots.ContainsKey(name))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.ExistingRobot,name));
                }

                this.garage.Manufacture(robot);

            }
            else if (robotType == nameof(PetRobot))
            {
                if (energy < 0 || energy > 100)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidEnergy);
                }
                else if (happiness < 0 || happiness > 100)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidHappiness);
                }

                robot = new PetRobot(name, energy, happiness, procedureTime);

                if (this.garage.Robots.Count == 10)
                {
                    throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);
                }
                else if (this.garage.Robots.ContainsKey(name))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.ExistingRobot,name));
                }

                this.garage.Manufacture(robot);

            }
            else if (robotType == nameof(WalkerRobot))
            {
                if (energy < 0 || energy > 100)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidEnergy);
                }
                else if (happiness < 0 || happiness > 100)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidHappiness);
                }

                robot = new WalkerRobot(name, energy, happiness, procedureTime);

                if (this.garage.Robots.Count == 10)
                {
                    throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);
                }
                else if (this.garage.Robots.ContainsKey(name))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.ExistingRobot,name));
                }

                this.garage.Manufacture(robot);

            }

            return $"{string.Format(OutputMessages.RobotManufactured,name)}";
        }


        public string Charge(string robotName, int procedureTime)
        {
            if (!this.garage.Robots.ContainsKey(robotName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot,robotName));
            }

            procedure = new Charge();
            robot = this.garage.Robots[robotName];

            procedure.DoService(robot, procedureTime);
            if(robotswithprocedures.ContainsKey("Charge"))
            {
                robotswithprocedures["Charge"].Add(robot);
            }
            else
            {
                this.robotswithprocedures.Add("Charge", new List<IRobot>());
                this.robotswithprocedures["Charge"].Add(robot);
            }

            return $"{string.Format(OutputMessages.ChargeProcedure,robotName)}";
        }

        public string TechCheck(string robotName, int procedureTime)
        {
            if (!this.garage.Robots.ContainsKey(robotName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot,robotName));
            }

            procedure = new TechCheck();
            robot = this.garage.Robots[robotName];
            procedure.DoService(robot, procedureTime);
            
            if (robotswithprocedures.ContainsKey("TechCheck"))
            {
                robotswithprocedures["TechCheck"].Add(robot);
            }
            else
            {
                this.robotswithprocedures.Add("TechCheck", new List<IRobot>());
                this.robotswithprocedures["TechCheck"].Add(robot);
            }

            return $"{string.Format(OutputMessages.TechCheckProcedure,robotName)}";
        }

        public string Chip(string robotName, int procedureTime)
        {
            if (!this.garage.Robots.ContainsKey(robotName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot,robotName));
            }

            procedure = new Chip();
            robot = this.garage.Robots[robotName];
            procedure.DoService(robot, procedureTime);
            
            if (robotswithprocedures.ContainsKey("Chip"))
            {
                robotswithprocedures["Chip"].Add(robot);
            }
            else
            {
                this.robotswithprocedures.Add("Chip", new List<IRobot>());
                this.robotswithprocedures["Chip"].Add(robot);
            }

            return $"{string.Format(OutputMessages.ChipProcedure,robotName)}";
        }


        public string Polish(string robotName, int procedureTime)
        {
            if (!this.garage.Robots.ContainsKey(robotName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot,robotName));
            }

            procedure = new Polish();
            robot = this.garage.Robots[robotName];
            procedure.DoService(robot, procedureTime);
            if (robotswithprocedures.ContainsKey("Polish"))
            {
                robotswithprocedures["Polish"].Add(robot);
            }
            else
            {
                this.robotswithprocedures.Add("Polish", new List<IRobot>());
                this.robotswithprocedures["Polish"].Add(robot);
            }
            return $"{string.Format(OutputMessages.PolishProcedure,robotName)}";
        }

        public string Rest(string robotName, int procedureTime)
        {
            if (!this.garage.Robots.ContainsKey(robotName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot,robotName));
            }

            procedure = new Rest();
            robot = this.garage.Robots[robotName];
            procedure.DoService(robot, procedureTime);
            if (robotswithprocedures.ContainsKey("Rest"))
            {
                robotswithprocedures["Rest"].Add(robot);
            }
            else
            {
                this.robotswithprocedures.Add("Rest", new List<IRobot>());
                this.robotswithprocedures["Rest"].Add(robot);
            }
            return $"{string.Format(OutputMessages.RestProcedure,robotName)}";

        }

        public string Sell(string robotName, string ownerName)
        {
            if (!this.garage.Robots.ContainsKey(robotName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot,robotName));
            }

            robot = this.garage.Robots[robotName];

            this.garage.Sell(robotName, ownerName);

            if(robot.IsChipped == true)
            {
                return $"{string.Format(OutputMessages.SellChippedRobot,ownerName)}";
            }
            else
            {
                return $"{string.Format(OutputMessages.SellNotChippedRobot,ownerName)}";
            }
            
        }

        public string Work(string robotName, int procedureTime)
        {
            if (!this.garage.Robots.ContainsKey(robotName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot,robotName));
            }

            procedure = new Work();
            robot = this.garage.Robots[robotName];
            procedure.DoService(robot, procedureTime);
            if (robotswithprocedures.ContainsKey("Work"))
            {
                robotswithprocedures["Work"].Add(robot);
            }
            else
            {
                this.robotswithprocedures.Add("Work", new List<IRobot>());
                this.robotswithprocedures["Work"].Add(robot);
            }
            return $"{string.Format(OutputMessages.WorkProcedure,robotName,procedureTime)}";
        }

        public string History(string procedureType)
        {
            var orderedRobots = this.robotswithprocedures.All(r => r.Key == procedureType);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{procedureType}");
            
                foreach (var key in robotswithprocedures.Keys.Where(K => K == procedureType))
                {
                    foreach (var robot in robotswithprocedures[key])
                    {
                        sb.AppendLine($" Robot type: {robot.GetType().Name} - {robot.Name} - Happiness: {robot.Happiness} - Energy: {robot.Energy}");
                    }
                }

            

            return sb.ToString().TrimEnd();
        }
    }
}
