﻿using Xunit;
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
    }
}