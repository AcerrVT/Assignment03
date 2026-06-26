using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal interface IFlightEnable
    {
        // The IFlightEnable interface defines the basic flight-related
        // methods that any flying object should implement.

        // Method to simulate the takeoff of a flying object.
        void TakeOff();

        // Method to simulate the landing of a flying object.
        void Land();

        // Method to simulate the flying action of a flying object.
        void Fly();

    }
}
