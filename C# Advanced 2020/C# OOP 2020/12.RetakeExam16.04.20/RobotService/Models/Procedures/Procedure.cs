using RobotService.Models.Procedures.Contracts;
using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Procedures
{
    public abstract class Procedure : IProcedure
    {
        private ICollection<IRobot> robots;
        public Procedure()
        {
            this.robots = new List<IRobot>();
        }

        public virtual void DoService(IRobot robot, int procedureTime)
        {
            if(robot.ProcedureTime < procedureTime)
            {
                throw new ArgumentException(ExceptionMessages.InsufficientProcedureTime);
            }

            robot.ProcedureTime -= procedureTime;
        }
        public string History()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var robot in robots)
            {
                sb.AppendLine($"{this.GetType().Name}");
                sb.AppendLine($" Robot type: {robot.GetType().Name} - {robot.Name} - Happiness: {robot.Happiness} - Energy: {robot.Energy}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
