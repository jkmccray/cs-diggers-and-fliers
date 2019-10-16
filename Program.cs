using System;

namespace DiggersAndFliers
{
    class Program
    {
        static void Main(string[] args)
        {
            Ant ant = new Ant();
            BettaFish bettaFish = new BettaFish();
            CopperheadSnake copperhead = new CopperheadSnake();
            Earthworm earthworm = new Earthworm();
            Finch finch = new Finch();
            Gerbil gerbil = new Gerbil();
            Mouse mouse = new Mouse();
            Parakeet parakeet = new Parakeet();
            Rattlesnake rattlesnake = new Rattlesnake();
            Terrapin terrapin = new Terrapin();

            AnimalsThatDig diggers = new AnimalsThatDig();
            diggers.AnimalsThatDigList.Add(ant);
            diggers.AnimalsThatDigList.Add(earthworm);


            AnimalsThatFly fliers = new AnimalsThatFly();
            fliers.AnimalsThatFlyList.Add(parakeet);
            fliers.AnimalsThatFlyList.Add(finch);

            AnimalsThatMoveOnGround movers = new AnimalsThatMoveOnGround();
            movers.AnimalsThatMoveOnGroundList.Add(copperhead);
            movers.AnimalsThatMoveOnGroundList.Add(gerbil);
            movers.AnimalsThatMoveOnGroundList.Add(mouse);
            movers.AnimalsThatMoveOnGroundList.Add(rattlesnake);

            AnimalsThatSwim swimmers = new AnimalsThatSwim();
            swimmers.AnimalsThatSwimList.Add(bettaFish);
            swimmers.AnimalsThatSwimList.Add(terrapin);


        }
    }
}
