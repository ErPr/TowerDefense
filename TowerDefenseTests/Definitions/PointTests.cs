﻿using Xunit;

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
        public void GivenPoint_WhenToStringCalled_ReturnStringOfPoint()
        {
            // Arrange
            var point = new Point(5, 7);
            var expected = "5, 7";

            // Act
            var actual = point.ToString();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void GiveTwoPoints_WhenEqual_ReturnTrue()
        {
            // Arrange
            var point = new Point(2, 2);
            var target = new Point(2, 2);
            var expected = true;

            // Act
            var actual = target.Equals(point);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void GiveTwoPoints_WhenNotEqual_ReturnFalse()
        {
            // Arrange
            var point = new Point(3, 5);
            var target = new Point(2, 2);
            var expected = false;

            // Act
            var actual = target.Equals(point);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void GivenPoint_WhenGetHashCodeCalled_ReturnCorrectHashCode()
        {
            // Arrange
            var point = new Point(2, 7);
            var expected = 69;

            // Act
            var actual = point.GetHashCode();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void GivenDistanceToCalled_WhenTwoIntParametersPassed_ReturnsCorrectDistance()
        {
            // Arrange
            var point = new Point(3, 4);
            var target = new Point(0, 0);
            var expected = 5.0;

            // Act
            var actual = target.DistanceTo(point.X, point.Y);

            // Assert
            Assert.Equal(expected, actual, 2);
        }

        [Fact()]
        public void GivenDistanceToCalled_WhenSinglePointParameterPassed_ReturnsCorrectDistance()
        {
            // Arrange
            var point = new Point(3, 4);
            var target = new Point(0, 0);
            var expected = 5.0;

            // Act
            var actual = target.DistanceTo(point);

            // Assert
            Assert.Equal(expected, actual, 2);
        }

        [Fact()]
        public void GivenTwoPoints_WhenPointsInSamePosition_ReturnsTrue()
        {
            // Arrange
            var point = new Point(3, 4);
            var target = new Point(3, 4);
            var expected = 0.0;

            // Act
            var actual = target.DistanceTo(point);

            // Assert
            Assert.Equal(expected, actual, 2);
        }

        [Fact()]
        public void DoesNotEqualNull()
        {
            var target = new Point(0, 0);
            Assert.False(target.Equals(null));
        }

        [Fact()]
        public void DistinctObjectsAreEqual()
        {
            var target = new Point(4, 5);
            Assert.True(target.Equals(new Point(4, 5)));
        }

        [Fact()]
        public void PointAreNotEqual()
        {
            var target = new Point(4, 5);
            Assert.False(target.Equals(new Point(4, 6)));
        }

        // Adding tests for GetHashCode(); whenever we change Equals(), we should change GetHashCode().
        [Fact()]
        public void SimilarPointsHaveDifferentHadCodes1()
        {
            var target = new Point(4, 5);
            Assert.NotEqual(new Point(5, 4).GetHashCode(), target.GetHashCode());
        }

        [Fact()]
        public void SimilarPointsHaveDifferentHashCodes2()
        {
            var target = new Point(4, 5);
            Assert.NotEqual(new Point(4, 6).GetHashCode(), target.GetHashCode());
        }

        [Fact()]
        public void EqualPointsHaveSameHashCodes()
        {
            var target = new Point(4, 5);
            Assert.Equal(new Point(4, 5).GetHashCode(), target.GetHashCode());
        }
    }
}