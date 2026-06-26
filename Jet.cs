using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal class Jet : IFlightEnable, ITrackable
    {
        //Jet class implements both IFlightEnable and ITrackable interfaces,
        //providing functionality for taking off, landing, flying,
        //and tracking the jet's flight path.

        //All methods below are implemented to simulate the behavior of the jet
        //in the air by printing messages to the console of the jet's actions (depending on the method called).
        public void TakeOff()
        {
            Console.WriteLine("Jet is taking off");
        }

        public void Land()
        {
            Console.WriteLine("Jet is landing");
        }

        public void Fly()
        {
            Console.WriteLine("Jet is flying");
        }

        public void Track()
        {
            Console.WriteLine("Tracking the jet's flight path");
        }

    }
}
