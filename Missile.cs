using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal class Missile : IMilitary, INavigable, IAutopilot, IEnergySource
    {
        // Missile class implements IMilitary, INavigable, etc interfaces
        // and provides its own implementation of the inherited methods.

        //All methods below are implemented to simulate the behavior of the Missile in
        // air by printing messages to the console of the Missile's actions
        // (depending on the method called).
        public void DeployWeapon()
        {
            Console.WriteLine("Missile deployed.");
        }
        public void SetDestination(string destination)
        {
            Console.WriteLine($"Missile is navigating to {destination}.");
        }
        public void EngageAutopilot()
        {
            Console.WriteLine("Missile autopilot engaged.");
        }
        public string GetEnergyType()
        {
            return "Missile uses Rocket Fuel";
        }

        //Custom method to simulate the Missile exploding.
        internal void Explode()
        {
            Console.WriteLine("Missile exploded.");
        }
    }
}
