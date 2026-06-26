using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal interface IEnergySource
    {
        //Method to get the type of energy source used by
        //(and defined within) the implementing class
        string GetEnergyType();
    }
}
