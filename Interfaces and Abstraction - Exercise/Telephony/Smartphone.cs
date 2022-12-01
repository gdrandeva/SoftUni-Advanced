using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : ISmartphone
    {
        public Smartphone()
        {

        }
        public string Browse(string url)
        {
            if (url.All(u => char.IsDigit(u)))
            {
                throw new ArgumentException(ExceptionMessages.InvalidURLMessage);
            }
            return $"Browsing: {url}!";
        }

        public string Call(string phoneNum)
        {
            if (!phoneNum.All(ch => char.IsDigit(ch)))
            {
                throw new ArgumentException(ExceptionMessages.InvalidNumberMessage);
            }
            return $"Calling... {phoneNum}";
        }
    }
}
