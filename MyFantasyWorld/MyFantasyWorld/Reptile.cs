using System;
using System.Collections.Generic;
using System.Text;

namespace MyFantasyWorld
{
    internal class Reptile:Animal
    {
        public string BloodType;
        public int HearthChambers;

        public Reptile(string name,string type,int countLegs):base(name,type,countLegs)
        {
            if(type == "Reptile")
            {
                BloodType = "Cold-Blooded";
                HearthChambers = 3;
            }
            else
            {
                return;
            }
        }

        public override void Details()
        {
            Console.WriteLine($"Name: {Name}\nAnimal Type: {Type}\nCount of Legs: {CountLegs}\nBlood Type: {BloodType}\nHearth Chamber: {HearthChambers}\n\n");
        }
    }
}
