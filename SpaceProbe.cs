using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal class SpaceProbe : ISensorEquipped, ICommunicable, INavigable, IAutopilot, IEnergySource
    {
        // SpaceProbe class implements ISensorEquipped, ICommunicable, etc interfaces
        // and provides its own implementation of the inherited methods.

        //All methods below are implemented to simulate the behavior of the SpaceProbe in
        // air by printing messages to the console of the SpaceProbe's actions
        // (depending on the method called).
        public void ReadSensors()
        {
            Console.WriteLine("Space probe is reading sensor data.");
        }
        public void TransmitData()
        {
            Console.WriteLine("Space probe is transmitting data.");
        }
        public void SetDestination(string destination)
        {
            Console.WriteLine($"Space probe is navigating to {destination}.");
        }
        public void EngageAutopilot()
        {
            Console.WriteLine("Space probe autopilot engaged.");
        }
        public string GetEnergyType()
        {
            return "Space Probe uses Solar Power";
        }

        internal void CollectSample(string sample)
        {
            Console.WriteLine($"Space probe is collecting a sample of {sample}.");
        }

    }
}
