namespace TowerDefense
{
    class Tower
    {
        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = .75;

        //add on path validation

        //static - initialized once used by all towers
        private static readonly System.Random _random = new System.Random();


        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSucessfulShot()
        {
            // Tower._random   is only necessary when accessing a static memeber from outside the class
            //return Tower._random.NextDouble() < _accuracy;
            return _random.NextDouble() < _accuracy;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    if(IsSucessfulShot())
                    {
                        invader.DecreaseHealth(_power);

                        if(invader.IsNeutralized)
                        {
                            System.Console.WriteLine();
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