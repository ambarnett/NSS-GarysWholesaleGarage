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
            fxs.Turn("right");
            fxs.Stop();

            modelS.Drive();
            modelS.Turn("left and judges you the entire time.");
            modelS.Stop();

            mx410.Drive();
            mx410.Turn("port");
            mx410.Stop();

            r1500.Drive();
            r1500.Stop();
            r1500.Turn("left");
        }
    }
}
