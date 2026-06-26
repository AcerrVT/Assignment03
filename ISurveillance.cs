using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal interface ISurveillance : ICameraEnabled, ISensorEquipped, ICommunicable
    {
        //Placeholder interface for surveillance, so that any class that inherits 
        //from it will have to implement the methods from ICameraEnabled,
        //ISensorEquipped, and ICommunicable interfaces.
    }
}
