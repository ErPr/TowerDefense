namespace TowerDefense
{
    interface IInvader1
    {
        bool HasScored { get; }
        int Health { get; }
        bool IsActive { get; }
        bool IsNeutralized { get; }
        MapLocation Location { get; }

        void DecreaseHealth(int factor);
        void Move();
    }
}