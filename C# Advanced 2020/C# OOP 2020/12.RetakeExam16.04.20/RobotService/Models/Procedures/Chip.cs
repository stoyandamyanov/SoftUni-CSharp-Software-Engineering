using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Procedures
{
    public class Chip : Procedure
    {
        public Chip()
        {
            
        }

        public override void DoService(IRobot robot, int procedureTime)
        {
            if (robot.ProcedureTime < procedureTime)
            {
                throw new ArgumentException(ExceptionMessages.InsufficientProcedureTime);
            }

            robot.ProcedureTime -= procedureTime;

            if(robot.IsChipped == true)
            {
                throw new ArgumentException(ExceptionMessages.AlreadyChipped);
            }
            robot.IsChipped = true;
            robot.Happiness -= 5;
        }
    }
}
