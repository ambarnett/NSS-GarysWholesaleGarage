using System;

namespace GarysWholesaleGarage
{
    public class Vehicle //! THIS IS THE BASE CLASS
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehicle carfully turns {direction}");
        }

        public virtual void Stop()
        {
            Console.WriteLine("The vehicle gently rolls to a stop.");
        }

    }
}