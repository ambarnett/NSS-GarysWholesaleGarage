using System;

namespace GarysWholesaleGarage
{
    public class Vehicle //! THIS IS THE BASE CLASS
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

    }
}