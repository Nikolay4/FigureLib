using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FigureLib.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Circle_CreateAndSquareCalculate_Equal()
        {
            // Arrange
            double radius = 2.5;
            Circle circle = new Circle(radius);
            // Act
            double square = circle.GetSquare();
            // Assert
            Assert.Equal(Math.PI * radius * radius, square);
        }

        [Fact]
        public void Circle_CreateNegativeRad_Exception()
        {
            // Arrange
            double radius = -2.5;
            // Act
            Action action = () => new Circle(radius);
            // Assert
            Exception ex = Assert.Throws<Exception>(action);
            Assert.Equal("радиус должен быть положительным!", ex.Message);
        }

        [Fact]
        public void Circle_SetNegativeRad_Exception()
        {
            // Arrange
            double radius = 2.5;
            Circle circle = new Circle(radius);
            // Act
            Action action = () => circle.Radius = -3;
            // Assert
            Exception ex = Assert.Throws<Exception>(action);
            Assert.Equal("радиус должен быть положительным!", ex.Message);
        }
    }
}
