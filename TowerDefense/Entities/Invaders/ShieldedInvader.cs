using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class ShieldedInvader: Invader
    {
        // Deleted in favor of creating static Random class
        //private static System.Random _random = new System.Random();

        public override int Health { get; protected set; } = 2;

        public ShieldedInvader(Path path) : base(path)
        {
            //uses the same path method
        }

        public override void DecreaseHealth(int factor)
        {
            if (TreehouseDefense.Definitions.Random.NextDouble() < .5)
            {
                base.DecreaseHealth(factor);
            }
            else
            {
                System.Console.WriteLine("Shot at a shielded invader, but it sustained no damage");
            }
        }
    }
}
