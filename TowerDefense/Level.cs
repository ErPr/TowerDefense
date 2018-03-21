namespace TowerDefense
{
    class Level
    {
        private readonly Invader[] _invaders;

        public Tower[] Towers { get; set; }

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }

        public bool Play()
        {
            //Run until all invaders are neutralized or invader reaches end

            //first each tower has an opportunity to fire on invaders

            //Count and more the invaders that are still active
        }
    }
}