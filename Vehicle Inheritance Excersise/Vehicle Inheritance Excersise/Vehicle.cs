using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Inheritance_Excersise
{
    class Vehicle
    {
        public string Color { get; set; }
        public string Manufacturer { get; set; }
        public string MaxSpeed { get; set; }
        public string Carriage { get; set; }
        public bool IsGasoline { get; set; }
        public bool IsElectricity { get; set; }
    }

    class WheeledVehicle : Vehicle
    {
        public void start()
        {
            Console.WriteLine("The Vehicle Starts");
        }

        public void stop()
        {
            Console.WriteLine("The Vehicle Stop");
        }

        public void drive()
        {
            Console.WriteLine("The Vehicle Drive");
        }

        public void refuel()
        {
            Console.WriteLine("The Vehicle Refuel");
        }

        public void RunAtMaxSpeed()
        {
            Console.WriteLine("The Vehicle Run At Max Speed");
        }

        public void TransportPeople()
        {
            Console.WriteLine("The Vehicle Transport People");
        }

    }

    class NonWheeledVehicle : Vehicle
    {

    }

    class FourWheledVehicle : WheeledVehicle
    {

    }

    class TwoWheledVehicle : WheeledVehicle
    {

    }

    class SeaVehicle : NonWheeledVehicle
    {

    }

    class AirVehicle : NonWheeledVehicle
    {

    }
}
