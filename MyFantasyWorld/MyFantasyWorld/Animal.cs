using System;
using System.Collections.Generic;
using System.Text;

namespace MyFantasyWorld
{
    internal class Animal
    {
        public string Name;
        public string Type;
        public string BloodType;
        public int CountLegs;


        public Animal()
        {
            Console.WriteLine("Animal added to list:");
        }

        public Animal(string name,string type,int countLegs):this()
        {
            Name = name;
            Type = type;
            CountLegs = countLegs;
            
        }

        public virtual void Details()
        {
            Console.WriteLine($"Name: {Name}\nAnimal Type: {Type}\nCount of Legs: {CountLegs}\n\n"); 
        }
    }
}
