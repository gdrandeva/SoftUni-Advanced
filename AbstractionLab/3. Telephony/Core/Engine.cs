using System;
using System.Collections.Generic;
using System.Text;
using Telephony.Core.Interfaces;

namespace Telephony.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
        }
    }
}
