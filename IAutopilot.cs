using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal interface IAutopilot
    {
        //Only implemented by classes/objects capable of following a trajectory automatically.

        //Method to engage the autopilot system of a vehicle or device,
        //allowing it to operate autonomously without direct human control.
        void EngageAutopilot();
    }
}
