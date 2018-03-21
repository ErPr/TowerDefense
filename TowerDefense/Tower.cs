namespace TowerDefense
{
    class Tower
    {
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
                
            }
        }
    }
}