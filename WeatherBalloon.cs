using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal class WeatherBalloon : ISensorEquipped, ICommunicable
    {
        // WeatherBalloon class implements ISensorEquipped and ICommunicable interfaces
        // and provides its own implementation of the inherited methods.

        //All methods below are implemented to simulate the behavior of the WeatherBalloon in
        // air by printing messages to the console of the WeatherBalloon's actions
        // (depending on the method called).
        public void ReadSensors()
        {
            Console.WriteLine("Weather balloon is reading sensor data.");
        }
        public void TransmitData()
        {
            Console.WriteLine("Weather balloon is transmitting data.");
        }
        internal void Float()
        {
            Console.WriteLine("Weather balloon is floating in the air.");
        }
    }
}
