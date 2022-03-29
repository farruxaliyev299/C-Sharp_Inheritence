using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    internal class Car
    {
        public string Brand;
        public string Model;
        public string Color;
        public int MaxSpeed;

        public Car()
        {
            Console.WriteLine("Car Created");
        }
        public Car(string brand,string model):this()
        {
            Brand = brand;
            Model = model;
        }

        public Car(string brand,string model,string color,int maxSpeed):this(brand,model)
        {
            Color = color;
            MaxSpeed = maxSpeed;
        }

        public virtual void Info()
        {
            Console.WriteLine($"Brand: {Brand} \nModel: {Model} \nColor: {Color} \nMaximum Speed: {MaxSpeed} \n\n");
        }
    }
}
