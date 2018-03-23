namespace TowerDefense
{
    abstract class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        protected virtual int StepSize { get; } = 1;

        public MapLocation Location => _path.GetLocationAt(_pathStep);

        public abstract int Health { get; protected set; }

        public bool HasScored => (_pathStep >= _path.Length) ? true : false;

        public bool IsNeutralized => (Health <= 0) ? true : false;

        public bool IsActive => !(IsNeutralized || HasScored);


        public Invader(Path path)
        {
            _path = path;
        }

        public void Move() => _pathStep += StepSize;

        public virtual void DecreaseHealth(int factor)
        {
            Health -= factor;
            System.Console.WriteLine("Shot at and hit an invader!");
        }
    }
}