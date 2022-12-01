using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Exceptions
{
    public class InvalidURLException : Exception
    {
        public const string DefaultURLException =
            "Invalid URL!";

        public InvalidURLException()
            : base(DefaultURLException)
        {

        }

        public InvalidURLException(string message)
            : base(message)
        {

        }
    }
}
