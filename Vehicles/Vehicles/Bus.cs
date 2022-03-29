using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    internal class Bus:Car
    {
        public int PassangerCount;
        public Bus(string brand,string model,string color,int maxSpeed,int passsangerCount):base(brand,model,color,maxSpeed)
        {
            PassangerCount = passsangerCount;
        }

        public override void Info()
        {
            Console.WriteLine($"Brand: {Brand} \nModel: {Model} \nColor: {Color} \nMaximum Speed: {MaxSpeed} \nPassangerSeats: {PassangerCount} \n\n");
        }
    }
}
