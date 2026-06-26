using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal class UFO : ICommunicable, INavigable, IAutopilot, IEnergySource, ISensorEquipped
    {
        // UFO class implements ICommunicable, ISensorEquipped, etc interfaces
        // and provides its own implementation of the inherited methods.

        //All methods below are implemented to simulate the behavior of the UFO in
        // air by printing messages to the console of the UFO's actions (depending on the method called).
        public void TransmitData()
        {
            Console.WriteLine("UFO is transmitting data.");
        }

        public void SetDestination(string destination)
        {
            Console.WriteLine($"UFO is navigating to {destination}.");
        }

        public void EngageAutopilot()
        {
            Console.WriteLine("UFO autopilot engaged.");
        }
        public string GetEnergyType()
        {
            return "UFO has an unknown Energy Source..";
        }
        public void ReadSensors()
        {
            Console.WriteLine("UFO is reading sensor data.");
        }

        //Custom method to simulate the UFO abducting something, the thing
        //being abducted must be fed into the method as a string.
        internal void Abduct(string thing)
        {
            Console.WriteLine($"UFO is abducting 1 {thing}");
        }

    }
}
