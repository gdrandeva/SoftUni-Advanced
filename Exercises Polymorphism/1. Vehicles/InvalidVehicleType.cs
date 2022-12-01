

namespace Vehicles
{
    using System;
    public class InvalidVehicleType : Exception
    {
        public const string DefaultMessage = "Vehicle type not supported!";

        //static polymorphism -> compile time
        public InvalidVehicleType()
            : base(DefaultMessage)
        {

        }

        public InvalidVehicleType(string message) 
            : base(message)
        {

        }
        
    }
}
