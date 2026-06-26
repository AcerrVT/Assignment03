using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal class FlightStageTracker : ITrackable
    {
        //FlightStageTracker class implements ITrackable interface
        //and provides its own implementation of the Track method.

        //FlightStageTracker aggregates the FlightStage enum
        //to track the current stage of the flight.

        private FlightStage stage;
        internal FlightStageTracker(FlightStage stage)
        {
            this.stage = stage;
        }

        //Implementation of the Track method from ITrackable interface, the method
        //,Track, tracks the current stage of the flight and printing it to the console.
        public void Track()
        {
            Console.WriteLine($"Tracking the flight stage: {stage}");
        }
    }
}
