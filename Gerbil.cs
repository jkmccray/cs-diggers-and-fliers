using System;

namespace DiggersAndFliers
{
    public class Gerbil : IWalking
    {
        public int WalkingDistance { get; set; }
        public int NumberOfLegs { get; set; }

        public void Run()
        {
            Console.WriteLine("The gerbil is running");
        }

        public void Walk()
        {
            Console.WriteLine("The gerbil is walking");
        }
    }
}