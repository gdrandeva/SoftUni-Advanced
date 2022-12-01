using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : IStationaryPhone
    {
        public string Call(string phoneNum)
        {
            if (!phoneNum.All(ch => char.IsDigit(ch)))
            {
                throw new ArgumentException(ExceptionMessages.InvalidNumberMessage);
            }

            return $"Dialing... {phoneNum}";
        }
    }
}
