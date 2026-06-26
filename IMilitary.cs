using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal interface IMilitary
    {
        //Only implemented by classes/objects capable of deploying weapons
        //or engaging in military operations.

        //Method to deploy a weapon
        void DeployWeapon();
    }
}
