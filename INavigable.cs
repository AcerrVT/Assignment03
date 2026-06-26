using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal interface INavigable
    {
        //Only used by classes/objects capable of navigating
        //or moving towards a specific destination.

        //Method to set the destination for navigation
        void SetDestination(string destination);
    }
}
