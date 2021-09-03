using System;

namespace GarysWholesaleGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero {MainColor = "Blue"};
            Tesla modelS = new Tesla {MainColor = "Red"};
            Cessna mx410 = new Cessna {MainColor = "Black"};
            Ram r1500 = new Ram {MainColor = "Brown"};

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            r1500.Drive();
        }
    }
}
