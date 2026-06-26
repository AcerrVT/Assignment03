using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal class ReconDrone : IMilitary, ISurveillance, IAutopilot, INavigable, IEnergySource
    {
        // ReconDrone class implements IMilitary, INavigable, etc interfaces
        // and provides its own implementation of the inherited methods.

        //All methods below are implemented to simulate the behavior of the ReconDrone in
        // air by printing messages to the console of the ReconDrone's actions
        // (depending on the method called).
        public void DeployWeapon()
        {
            Console.WriteLine("Recon drone deployed its weapon.");
        }
        public void CaptureImage()
        {
            Console.WriteLine("Recon drone is capturing images.");
        }
        public void ReadSensors()
        {
            Console.WriteLine("Recon drone is reading sensor data.");
        }
        public void TransmitData()
        {
            Console.WriteLine("Recon drone is transmitting data.");
        }
        public void EngageAutopilot()
        {
            Console.WriteLine("Recon drone autopilot engaged.");
        }
        public void SetDestination(string destination)
        {
            Console.WriteLine($"Recon drone is navigating to {destination}.");
        }
        public string GetEnergyType()
        {
            return "Recon Drone uses Battery";
        }
        internal void Analyze()
        {
            Console.WriteLine("Recon drone is analyzing the environment.");
        }

    }
}
