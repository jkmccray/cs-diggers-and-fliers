using System;

namespace DiggersAndFliers
{
    public class Mouse : IWalking
    {
        public int WalkingDistance { get; set; }
        public int NumberOfLegs { get; set; }

        public void Run()
        {
            Console.WriteLine("The mouse is running");
        }

        public void Walk()
        {
            Console.WriteLine("The mouse is walking");
        }
    }
}