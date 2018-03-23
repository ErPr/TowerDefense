namespace TowerDefense
{
    class Level
    {
        private readonly IInvader[] _invaders;

        public Tower[] Towers { get; set; }

        public Level(IInvader[] invaders)
        {
            _invaders = invaders;
        }

        //returns true if player wins, false if player loses.
        public bool Play()
        {
            //Run until all invaders are neutralized or invader reaches end
            int remainingInvaders = _invaders.Length;

            while(remainingInvaders > 0)
            {
                //first each tower has an opportunity to fire on invaders
                foreach(Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }

                //Count and more the invaders that are still active
                remainingInvaders = 0;

                foreach(IInvader invader in _invaders)
                {
                    if (invader.IsActive)
                    {
                        invader.Move();

                        if (invader.HasScored)
                        {
                            return false;
                        }

                        remainingInvaders++;
                    }
                }
            }
            return true;
        }
    }
}