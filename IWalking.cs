namespace DiggersAndFliers
{
    public interface IWalking
    {
        int WalkingDistance { get; set; }
        int NumberOfLegs { get; set; }
        void Run();
        void Walk();
    }
}