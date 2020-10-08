using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Procedures
{
    public class TechCheck : Procedure
    {
        public TechCheck()
        {
        }

        public override void DoService(IRobot robot, int procedureTime)
        {
            if (robot.ProcedureTime < procedureTime)
            {
                throw new ArgumentException(ExceptionMessages.InsufficientProcedureTime);
            }

            robot.Energy -= 8;
            if(robot.IsChecked != true)
            {
                robot.IsChecked = true;
            }
            else
            {
                robot.Energy -= 8;
            }

            robot.ProcedureTime -= procedureTime;
        }
    }
}
