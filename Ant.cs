using System;

namespace DiggersAndFliers
{
    public class Ant : IDigging, IWalking
    {
        public int WalkingDistance { get; set; }
        public int NumberOfLegs { get; set; }

        public void Dig()
        {
            Console.WriteLine("The ant is digging.");
        }

        public void Run()
        {
            Console.WriteLine("The ant is running.");
        }

        public void Walk()
        {
            Console.WriteLine("The ant is walking.");
        }
    }
}