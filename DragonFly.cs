using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal class DragonFly : IFlightEnable
    {
        // DragonFly class implements IFlightEnable interface
        // and provides its own implementation of the flight methods.

        //Internal attributes to store the name and type of the dragonfly.

        private string name;
        private string type;

        //Constructor to initialize the name and type of the dragonfly when an object is created.
        internal DragonFly(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        //All methods below are implemented to simulate the behavior of a DragonFly in space
        //by printing messages to the console of the DragonFly's actions (depending on the method called).
        public void TakeOff()
        {
            Console.WriteLine("DragonFly is taking off");
        }

        public void Land()
        {
            Console.WriteLine("DragonFly is landing");
        }

        public void Fly()
        {
            Console.WriteLine("DragonFly is flying");
        }

    }
}
