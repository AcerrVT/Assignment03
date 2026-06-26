using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal class Drone : ICameraEnabled, ISensorEquipped, IAutopilot, INavigable, IEnergySource
    {
        // Drone class implements ICameraEnabled, ISensorEquipped, etc interfaces
        // and provides its own implementation of the inherited methods.

        //All methods below are implemented to simulate the behavior of the Drone in
        // air by printing messages to the console of the Drone's actions (depending on the method called).
        public void CaptureImage()
        {
            Console.WriteLine("Drone is capturing an image.");
        }
        public void ReadSensors()
        {
            Console.WriteLine("Drone is reading sensor data.");
        }
        public void EngageAutopilot()
        {
            Console.WriteLine("Drone autopilot engaged.");
        }
        public void SetDestination(string destination)
        {
            Console.WriteLine($"Drone is navigating to {destination}.");
        }
        public string GetEnergyType()
        {
            return "Drone uses a Battery";
        }

        //Custom method to simulate the Drone circling in the air.
        internal void Circle()
        {
            Console.WriteLine("Drone is circling.");
        }
    }
}
