using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefense;

namespace TowerDefenseTests.Mocks
{
    public class InvaderMock : IInvader
    {
        public int Health { get; set; } = 2;

        public bool HasScored => false;

        public bool IsNeutralized => false;

        public bool IsActive => true;

        public MapLocation Location { get; set; }

        public void DecreaseHealth(int factor)
        {
            Health -= factor;
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
