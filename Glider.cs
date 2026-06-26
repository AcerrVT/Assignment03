using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal class Glider : INavigable, IAutopilot
    {
        // Glider class implements INavigable and IAutopilot interfaces
        // and provides its own implementation of the inherited methods.

        //All methods below are implemented to simulate the behavior of the Drone in
        // air by printing messages to the console of the Drone's actions (depending on the method called).
        public void SetDestination(string destination)
        {
            Console.WriteLine($"Glider is navigating to {destination}.");
        }
        public void EngageAutopilot()
        {
            Console.WriteLine("Glider autopilot engaged.");
        }

        //Custom method to simulate the Glider soaring in the air.
        internal void Soar()
        {
            Console.WriteLine("Glider is soaring.");
        }
    }
}
