using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal class SelfDrivingCar : ISmartVehicle, ISensorEquipped, ICommunicable
    {
        // SelfDrivingCar class implements ISmartVehicle which inherits from
        // INavigable, IAutopilot, IEnergySource, and it also implements
        // ISensorEquipped, ICommunicable interfaces and provides its own
        // implementation of the inherited methods.

        //All methods below are implemented to simulate the behavior of the SelfDrivingCar in
        // air by printing messages to the console of the SelfDrivingCar's actions
        // (depending on the method called).
        public void SetDestination(string destination)
        {
            Console.WriteLine($"Self-driving car is navigating to {destination}.");
        }
        public void EngageAutopilot()
        {
            Console.WriteLine("Self-driving car autopilot engaged.");
        }
        public string GetEnergyType()
        {
            return "Electric";
        }
        public void ReadSensors()
        {
            Console.WriteLine("Self-driving car is reading sensor data.");
        }
        public void TransmitData()
        {
            Console.WriteLine("Self-driving car is transmitting data.");
        }
        internal void Park()
        {
            Console.WriteLine("Self-driving car is parking.");
        }
    }
}
