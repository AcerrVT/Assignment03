using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal class AlienShip: IMilitary, ICommunicable, INavigable, IAutopilot, IEnergySource, ISensorEquipped
    {
        // AlienShip class implements IMilitary, ICommunicable, etc interfaces
        // and provides its own implementation of the inherited methods.

        //All methods below are implemented to simulate the behavior of the AlienShip in
        // air by printing messages to the console of the AlienShip's actions
        // (depending on the method called).
        public void DeployWeapon()
        {
            Console.WriteLine("Alien ship deployed its weapon.");
        }
        public void TransmitData()
        {
            Console.WriteLine($"Alien ship is transmitting data.");
        }
        public void SetDestination(string destination)
        {
            Console.WriteLine($"Alien ship is navigating to {destination}.");
        }
        public void EngageAutopilot()
        {
            Console.WriteLine("Alien ship autopilot engaged.");
        }
        public string GetEnergyType()
        {
            return "Alien Ship uses Plasma Energy";
        }
        public void ReadSensors()
        {
            Console.WriteLine("Alien ship is reading sensor data.");
        }

        //Custom method to simulate the AlienShip cloaking.
        internal void Cloak()
        {
            Console.WriteLine("Alien ship is cloaking.");
        }
    }
}
