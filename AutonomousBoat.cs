using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal class AutonomousBoat : ISmartVehicle, ISensorEquipped, ICommunicable
    {
        // Autonomous Boat class implements ISmartVehicle which inherits from
        // INavigable, IAutopilot, IEnergySource interfaces, and also implements
        // ISensorEquipped and ICommunicable interfaces.

        //All methods below are implemented to simulate the behavior of the Boat in
        // air by printing messages to the console of the Boat's actions
        // (depending on the method called).
        public void SetDestination(string destination)
        {
            Console.WriteLine($"Autonomous boat is navigating to {destination}.");
        }
        public void EngageAutopilot()
        {
            Console.WriteLine("Autonomous boat autopilot engaged.");
        }
        public string GetEnergyType()
        {
            return "Diesel";
        }
        public void ReadSensors()
        {
            Console.WriteLine("Autonomous boat is reading sensor data.");
        }
        public void TransmitData()
        {
            Console.WriteLine("Autonomous boat is transmitting data.");
        }
        internal void Anchor()
        {
            Console.WriteLine("Autonomous boat is anchoring.");
        }

    }
}
