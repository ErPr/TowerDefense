using Xunit;
using TowerDefense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense.Tests
{
    public class PointTests
    {
        [Fact()]
        public void PointTest()
        {
            // Arrange
            int x = 5;
            int y = 6;

            // Act
            var point = new Point(x, y);

            // Assert
            Assert.Equal(x, point.X);
            Assert.Equal(y, point.Y);
        }

        [Fact()]
        public void ToStringTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void EqualsTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void GetHashCodeTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void DistanceToTest()
        {
            // Arrange
            var point = new Point(3, 4);
            var target = new Point(0, 0);

            // Act
            var expected = 5.0;
            var actual = target.DistanceTo(point);

            // Assert
            Assert.Equal(expected, actual, 2);
        }

        [Fact()]
        public void DistanceToPointAtSamePosition()
        {
            // Arrange
            var point = new Point(3, 4);
            var target = new Point(3, 4);

            // Act
            var expected = 0.0;
            var actual = target.DistanceTo(point);

            // Assert
            Assert.Equal(expected, actual, 2);
        }

        [Fact()]
        public void DistanceToTest1()
        {
            Assert.True(false, "This test needs an implementation");
        }
    }
}