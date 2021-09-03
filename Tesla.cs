using System;

namespace GarysWholesaleGarage
{
    public class Tesla : Vehicle //* Electric car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            //! method definition omitted
            Console.WriteLine($"Your Tesla is charged to {this.BatteryKWh}KWh");
        }
    }
}