using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal class Satellite : IOrbitEarth
    {
        // The Satellite class implements the IOrbitEarth interface,
        // which means it must provide implementations for the AchieveOrbit,
        // TakeOff, Land, and Fly methods.

        //All methods below are implemented to simulate the behavior of a satellite in space
        //by printing messages to the console of the satellite's actions.
        public virtual void AchieveOrbit()
        {
            Console.WriteLine("Satellite is achieving orbit around Earth");
        }
        public virtual void TakeOff()
        {
            Console.WriteLine("Satellite is launching into space");
        }
        public virtual void Land()
        {
            Console.WriteLine("Satellite is re-entering Earth's atmosphere and landing.");
        }
        public virtual void Fly()
        {
            Console.WriteLine("Satellite is orbiting Earth, it's flying!");
        }

    }
}
