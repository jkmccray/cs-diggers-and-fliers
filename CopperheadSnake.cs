using System;

namespace DiggersAndFliers
{
    public class CopperheadSnake : IWalking
    {
        public int WalkingDistance { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int NumberOfLegs { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Run()
        {
            Console.WriteLine("I don' run");
        }
        public void Walk()
        {
            Console.WriteLine("The copperhead is slithering");
        }
    }
}