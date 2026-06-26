using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal class Animal
    {
        // The Animal class is an abstract class that serves as a base
        // for different types of animals.

        //This class has two virtual methods, Move and Sleep, which are inherited
        //but aren't displayed in main within this assignment. 
        internal virtual void Move()
        {
            Console.WriteLine("The animal moves.");
        }
        internal virtual void Sleep()
        {
            Console.WriteLine("The animal sleeps.");
        }

    }
}
