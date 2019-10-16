using System;

namespace DiggersAndFliers
{
    public class Terrapin : IWalking, ISwimming
    {
        public int NumberOfLegs { get; set; }

        public int MaximumDepth { get; set; }
        public int WalkingDistance { get; set; }

        public void Run()
        {
            Console.WriteLine("The terrapin is running");
        }

        public void Swim()
        {
            Console.WriteLine("The terrapin is swimming");
        }

        public void Walk()
        {
            Console.WriteLine("The terrapin is walking");
        }
    }
}