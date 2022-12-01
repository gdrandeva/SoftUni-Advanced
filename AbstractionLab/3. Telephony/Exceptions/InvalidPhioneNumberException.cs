using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Exceptions
{
    public class InvalidPhioneNumberException : Exception
    {
        private const string DefaultExceptionMessage =
            "Invalid number!";

        public InvalidPhioneNumberException()
            : base(DefaultExceptionMessage)
        {

        }

        public InvalidPhioneNumberException(string message)
            : base(message)
        {

        }
    }
}
