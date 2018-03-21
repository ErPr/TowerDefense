namespace TowerDefense
{
    class Tower
    {
        private const int _range = 1;
        private const int power = 1;
        //add on path validation
        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, power))
                {
                    invader.DecreaseHealth(_range);
                    break;
                }
            }
        }
    }
}