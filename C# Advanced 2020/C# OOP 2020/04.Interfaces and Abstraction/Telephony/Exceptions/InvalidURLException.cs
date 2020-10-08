using System;

namespace Telephony.Exceptions
{
    public class InvalidURLException : Exception
    {
        private const string INVALID_URL_EXCEPTION = "Invalid URL!";

        public InvalidURLException()
            :base(INVALID_URL_EXCEPTION)
        {

        }

        public InvalidURLException(string message) : base(message)
        {

        }
    }
}
