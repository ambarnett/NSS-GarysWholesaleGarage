using System;

namespace GarysWholesaleGarage
{
    public class Cessna : Vehicle //* Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            //! method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna looms menacingly overhead. Buzzzzzz");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Cessna made a 120 degree {direction} bank");
        }

        public override void Stop()
        {
            Console.WriteLine("The Cessna came to a complete stop... by flying directly into the side of a hill. Pilot safely ejected.");
        }
    }
}