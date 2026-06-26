using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal interface ISensorEquipped
    {
        //Used by classes that have sensors to read data from the environment.

        //Method to read sensor data, to be implemented by classes that implement
        //this interface
        void ReadSensors();
    }
}
