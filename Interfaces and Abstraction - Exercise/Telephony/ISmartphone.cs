using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface ISmartphone
    {
        string Call(string phoneNum);

        string Browse(string url);
    }
}
