using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal class Dolphin : Animal, ISensorEquipped, INavigable
    {
        // Dolphin class inherits from Animal class and implements ISensorEquipped interface,
        // it overrides the Move and Sleep methods from the Animal class and provides its own
        // implementation of the ReadSensors method from the ISensorEquipped interface.

        //All methods below are implemented to simulate the behavior of the Dolphin in
        // air by printing messages to the console of the Dolphin's actions
        // (depending on the method called).
        internal override void Move()
        {
            Console.WriteLine("Dolphin is moving");
        }
        internal override void Sleep()
        {
            Console.WriteLine("Dolphin is sleeping");
        }
        public void ReadSensors()
        {
            Console.WriteLine("Dolphin is reading sensor data.");
        }
        public void SetDestination(string destination)
        {
            Console.WriteLine($"Dolphin is navigating to {destination}.");
        }
        internal void Swim()
        {
            Console.WriteLine("Dolphin is swimming.");
        }
    }
}
