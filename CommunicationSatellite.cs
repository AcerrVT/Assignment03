using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal class CommunicationSatellite : Satellite, ICommunicable, ISensorEquipped
    {
        // Comm. Sat class inherits from Satellite class meaning it 
        //by default inherits the methods from the interfaces: AchieveOrbit,
        //TakeOff, Land, and Fly and implements ICommunicable and ISensorEquipped interfaces.

        //All methods below are implemented to simulate the behavior of the Comm. Sat. in
        // air by printing messages to the console of the Comm. Sat's actions
        // (depending on the method called).
        public override void AchieveOrbit()
        {
            Console.WriteLine("Comm. Sat. is achieving orbit around Earth");
        }
        public override void TakeOff()
        {
            Console.WriteLine("Comm. Sat. is launching into space");
        }
        public override void Land()
        {
            Console.WriteLine("Comm. Sat. is re-entering Earth's atmosphere and landing.");
        }
        public override void Fly()
        {
            Console.WriteLine("Comm. Sat. is orbiting Earth, it's flying!");
        }
        public void TransmitData()
        {
            Console.WriteLine("Comm. Sat. is transmitting data to Earth.");
        }
        public void ReadSensors()
        {
            Console.WriteLine("Comm. Sat. is reading sensor data.");
        }
        internal void BackupNetwork()
        {
            Console.WriteLine("Comm. Sat. is backing up the network.");
        }
    }
}
