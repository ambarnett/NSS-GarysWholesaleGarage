using System;

namespace GarysWholesaleGarage
{
    public class Ram : Vehicle //* Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            //! method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives uncontrolably on the sidewalk. VROOM");
        }

        public override void Stop()
        {
            Console.WriteLine("THIS TRUCK AIN'T GOT NO BRAKES");
        }
    }
}