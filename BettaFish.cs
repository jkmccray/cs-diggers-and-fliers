using System;

namespace DiggersAndFliers
{
    public class BettaFish : ISwimming
    {
        public int MaximumDepth => throw new NotImplementedException();

        public void Swim()
        {
            Console.WriteLine("The betta fish is swimming");
        }
    }
}