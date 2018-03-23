namespace TowerDefense
{
    abstract class Tower
    {
        //changing these members to protected properties - keeping code for reference
        //private const int _range = 1;
        //private const int _power = 1;
        //private const double _accuracy = .75;

        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;

        //add on path validation

        //static - initialized once used by all towers
        private static readonly System.Random _random = new System.Random();


        protected readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSucessfulShot()
        {
            // Tower._random   is only necessary when accessing a static memeber from outside the class
            //return Tower._random.NextDouble() < _accuracy;
            return _random.NextDouble() < Accuracy;
        }

        public void FireOnInvaders(IInvader[] invaders)
        {
            foreach (IInvader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if(IsSucessfulShot())
                    {
                        invader.DecreaseHealth(Power);

                        if(invader.IsNeutralized)
                        {
                            System.Console.WriteLine("Neutralized invader at " + invader.Location + "!");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Shot at and missed an invader");
                    }
                    break;
                }
            }
        }
    }
}