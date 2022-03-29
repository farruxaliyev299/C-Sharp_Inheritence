using System;

namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car mercedes = new Car("Mercedes", "ML450", "Grey", 360);
            mercedes.Info();

            Car mercedesBus = new Bus("Mercedes", "BigBoy", "White", 120, 16);
            mercedesBus.Info();
        }
    }
}
