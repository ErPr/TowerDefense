using TowerDefense;
using Xunit;

namespace TowerDefenseTests.Definitions
{
    public class PathTests
    {
        private Map _map3x3;
        private MapLocation[] _pathLocations3;
        private Path _path3;

        public PathTests()
        {
            _map3x3 = new Map(3, 3);

            _pathLocations3 = new MapLocation[]
            {
                new MapLocation(0, 1, _map3x3),
                new MapLocation(1, 1, _map3x3),
                new MapLocation(2, 1, _map3x3)
            };

            _path3 = new Path(_pathLocations3);

        }

        [Fact]
        public void MapLocationIsOnPath()
        {
            var target = _path3;

            Assert.True(target.IsOnPath(new MapLocation(0, 1, _map3x3)));
        }

        [Fact]
        public void MapLocationNotOnPath()
        {
            var target = _path3;

            Assert.False(target.IsOnPath(new MapLocation(3, 3, _map3x3)));
            //Assert.Throws<OutOfBoundsException>(() => target.IsOnPath(new MapLocation(3, 3, _map3x3)));
        }
    }
}

// *******  END OF CLASS - BEGIN NOTES ******* // 

//using TowerDefense;
//using Xunit;

//namespace TowerDefenseTests.Definitions
//{
//    public class PathTests
//    {
//        [Fact]
//        public void MapLocationIsOnPath()
//        {
//            var map = new Map(3, 3);

//            MapLocation[] pathLocations =
//            {
//                new MapLocation(0, 1, map),
//                new MapLocation(1, 1, map),
//                new MapLocation(2, 1, map)
//            };

//            var target = new Path(pathLocations);

//            Assert.True(target.IsOnPath(new MapLocation(0, 1, map)));
//        }

//        [Fact]
//        public void MapLocationNotOnPath()
//        {
//            var map = new Map(3, 3);

//            MapLocation[] pathLocations =
//            {
//                new MapLocation(0, 1, map),
//                new MapLocation(1, 1, map),
//                new MapLocation(2, 1, map)
//            };

//            var target = new Path(pathLocations);

//            Assert.False(target.IsOnPath(new MapLocation(3, 1, map)));
//        }
//    }
//}

