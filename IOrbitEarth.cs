using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal interface IOrbitEarth : IFlightEnable
    {
        // The IOrbitEarth interface extends the IFlightEnable interface, 
        // which means that any class implementing IOrbitEarth must also implement
        // the methods defined in IFlightEnable (TakeOff, Land, Fly) in addition
        // to the AchieveOrbit method.

        // This interface is designed for ONLY for objects that can achieve orbit
        // around Earth.

        // The method below is intended to simulate the action of achieving orbit
        // by printing a message to the console when called.
        void AchieveOrbit();
    }
}
