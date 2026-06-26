using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal class Bee : Animal, ISensorEquipped
    {
        // Bee class inherits from Animal class and implements ISensorEquipped interface,
        // it overrides the Move and Sleep methods from the Animal class and provides its own
        // implementation of the ReadSensors method from the ISensorEquipped interface.

        //All methods below are implemented to simulate the behavior of the Bee in
        // air by printing messages to the console of the Bee's actions
        // (depending on the method called).
        internal override void Move()
        {
            Console.WriteLine("Bee is moving");
        }
        internal override void Sleep()
        {
            Console.WriteLine("Bee is sleeping");
        }
        public void ReadSensors()
        {
            Console.WriteLine("Bee is reading sensor data.");
        }
        internal void makeHoney()
        {
            Console.WriteLine("Bee is making honey.");
        }
    }
}
