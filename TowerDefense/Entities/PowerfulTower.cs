using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class PowerfulTower : Tower
    {
        protected override int Power { get; } = 2;

        public PowerfulTower(MapLocation _location) : base(_location)
        {

        }
    }
}
