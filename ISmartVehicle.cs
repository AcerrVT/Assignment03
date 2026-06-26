using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal interface ISmartVehicle : INavigable, IAutopilot, IEnergySource
    {
        //Placeholder interface for smart vehicles, so that any class that inherits 
        //from it will have to implement the methods from INavigable, IAutopilot,
        //and IEnergySource interfaces.
    }
}
