using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal class Truck : ITrackable
    {
        //Truck class implements ITrackable interface,
        //providing functionality for tracking the truck's route.
        public void Track()
        {
            Console.WriteLine("Tracking the truck's route");
        }
    }
}
