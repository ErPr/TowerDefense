﻿using Xunit;
using TowerDefense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense.Tests
{
    public class MapLocationTests
    {
        [Fact()]
        public void ShouldThrowIfNotOnMap()
        {
            var map = new Map(3, 3);
            var exception = Assert.Throws<OutOfBoundsException>(() => new MapLocation(3, 3, map));
        }
    }
}