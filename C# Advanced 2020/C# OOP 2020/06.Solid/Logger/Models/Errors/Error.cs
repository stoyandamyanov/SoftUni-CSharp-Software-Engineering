using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using System;

namespace Logger.Models.Errors
{
    public class Error : IError
    {
        public Error(DateTime datetime,string message,Level level)
        {
            this.dateTime = datetime;
            this.Message = message;
            this.Level = level;
        }
        public DateTime dateTime { get; private set; }

        public string Message { get; private set; }

        public Level Level { get; private set; }
    }
}
