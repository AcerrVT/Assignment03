using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal class Bird : Animal, IFlightEnable, ITrackable
    {
        // Bird class inherits from Animal and implements both
        // IFlightEnable and ITrackable interfaces, providing functionality
        // for taking off, landing, flying, and tracking the bird's flight path.

        //All methods below are implemented to simulate the behavior of a Bird in 
        //the air by printing messages to the console of the Bird's actions (depending on the method called).

        //Plus, it inherited the methods, Move and Sleep, but doesn't use
        //them inside of main. 
        public void TakeOff()
        {

            Console.WriteLine("Bird is taking off");
        }
        public void Land()
        {
            Console.WriteLine("Bird is landing");
        }
        public void Fly()
        {
            Console.WriteLine("Bird is flying");
        }
        public void Track()
        {
            Console.WriteLine("Tracking the bird's flight path");
        }

        internal override void Move()
        {
            Console.WriteLine("Bird is moving");
        }

        internal override void Sleep()
        {
            Console.WriteLine("Bird is sleeping");
        }
    }
}
