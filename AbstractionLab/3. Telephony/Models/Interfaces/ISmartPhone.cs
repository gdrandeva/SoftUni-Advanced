﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Models.Interfaces
{
    public interface ISmartPhone : IStationaryPhone
    {
        string BrowseURL(string url);
    }
}
