using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal interface ICommunicable
    {
        //Method to transmit data, to be implemented by classes that implement this interface
        void TransmitData();
    }
}
