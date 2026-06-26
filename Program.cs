using System.Reflection;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creation of lists for each interface type to store the objects that implement them
            List<INavigable> navigableObjects = new List<INavigable>();
            List<ICommunicable> communicableObjects = new List<ICommunicable>();
            List<IMilitary> militaryObjects = new List<IMilitary>();
            List<IAutopilot> autopilotObjects = new List<IAutopilot>();
            List<ISensorEquipped> sensorObjects = new List<ISensorEquipped>();
            List<IEnergySource> energyPoweredObjects = new List<IEnergySource>();

            //Assignment of objects to the navigableObjects list, only using objects
            //that implement the INavigable interface
            navigableObjects.Add(new Drone());
            navigableObjects.Add(new Missile());
            navigableObjects.Add(new AlienShip());
            navigableObjects.Add(new UFO());
            navigableObjects.Add(new Glider());
            navigableObjects.Add(new SpaceProbe());
            navigableObjects.Add(new ReconDrone());

            //Creation of a destination variable to be used for the SetDestination method
            string destination = "Thailand";

            //Iterating through the navigableObjects list and calling the SetDestination method for each object
            foreach (INavigable item in navigableObjects)
            {
                item.SetDestination(destination);
            }

            Console.WriteLine();

            //Assignment of objects to the communicableObjects list, only using objects
            //that implement the ICommunicable interface
            communicableObjects.Add(new CommunicationSatellite());
            communicableObjects.Add(new SpaceProbe());
            communicableObjects.Add(new SelfDrivingCar());
            communicableObjects.Add(new WeatherBalloon());
            communicableObjects.Add(new AlienShip());
            communicableObjects.Add(new UFO());
            communicableObjects.Add(new AutonomousBoat());

            //Iterating through the communicableObjects list and calling the TransmitData method for each object
            foreach (ICommunicable item in communicableObjects)
            {
                item.TransmitData();
            }

            Console.WriteLine();

            //Assignment of objects to the militaryObjects list, only using objects
            //that implement the IMilitary interface
            militaryObjects.Add(new Missile());
            militaryObjects.Add(new AlienShip());
            militaryObjects.Add(new ReconDrone());

            //Iterating through the militaryObjects list and calling the DeployWeapon method for each object
            foreach (IMilitary item in militaryObjects)
            {
                item.DeployWeapon();
            }

            Console.WriteLine();

            //Assignment of objects to the autopilotObjects list, only using objects
            //that implement the IAutopilot interface
            autopilotObjects.Add(new Drone());
            autopilotObjects.Add(new Missile());
            autopilotObjects.Add(new AlienShip());
            autopilotObjects.Add(new UFO());
            autopilotObjects.Add(new Glider());
            autopilotObjects.Add(new SpaceProbe());
            autopilotObjects.Add(new ReconDrone());

            //Iterating through the autopilotObjects list and calling the EngageAutopilot method for each object
            foreach (IAutopilot item in autopilotObjects)
            {
                item.EngageAutopilot();
            }

            Console.WriteLine();

            //Assignment of objects to the sensorObjects list, only using objects
            //that implement the ISensorEquipped interface
            sensorObjects.Add(new Drone());
            sensorObjects.Add(new Bee());
            sensorObjects.Add(new WeatherBalloon());
            sensorObjects.Add(new SpaceProbe());
            sensorObjects.Add(new Dolphin());
            sensorObjects.Add(new SelfDrivingCar());
            sensorObjects.Add(new AlienShip());
            sensorObjects.Add(new UFO());
            sensorObjects.Add(new ReconDrone());
            sensorObjects.Add(new CommunicationSatellite());
            sensorObjects.Add(new AutonomousBoat());

            //Iterating through the sensorObjects list and calling the ReadSensors method for each object
            foreach (ISensorEquipped item in sensorObjects)
            {
                item.ReadSensors();
            }

            Console.WriteLine();

            //Assignment of objects to the energyPoweredObjects list, only using objects
            //that implement the IEnergySource interface
            energyPoweredObjects.Add(new Drone());
            energyPoweredObjects.Add(new Missile());
            energyPoweredObjects.Add(new AlienShip());
            energyPoweredObjects.Add(new UFO());
            energyPoweredObjects.Add(new SpaceProbe());
            energyPoweredObjects.Add(new ReconDrone());

            //Iterating through the energyPoweredObjects list and calling the GetEnergyType method for each object
            foreach (IEnergySource item in energyPoweredObjects)
            {
                Console.WriteLine(item.GetEnergyType());
            }
        }
    }
}
