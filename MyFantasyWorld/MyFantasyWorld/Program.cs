using System;

namespace MyFantasyWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal at = new Mammal("At","Mammal",4);
            at.Details();

            Animal timsah = new Reptile("Timsah", "Reptile", 4);
            timsah.Details();
        }
    }
}
