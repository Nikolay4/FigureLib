using System;
using Xunit;

namespace FigureLib.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Triangle_CreateAndSquareCalculate_Equal()
        {
            // Arrange
            Triangle triangle = new Triangle(1.1, 2.2, 3.3);
            // Act
            double square = triangle.GetSquare();
            // Assert
            Assert.Equal(square, calculateTriangleSquare(1.1, 2.2, 3.3));
        }

        [Fact]
        public void Triangle_CreateNotTriangle_Exception()
        {
            // Arrange
            double a = 1;
            double b = 2;
            double c = 4;
            // Act
            Action action = () => new Triangle(a, b, c);
            // Assert
            Exception ex = Assert.Throws<Exception>(action);
            Assert.Equal("из данных длин сторон невозможно составить треугольник", ex.Message);
        }

        [Fact]
        public void Triangle_CreateNegativeSide_Exception()
        {
            // Arrange
            double a = 4;
            double b = -1;
            double c = 3;
            // Act
            Action action = () => new Triangle(a, b, c);
            // Assert
            Exception ex = Assert.Throws<Exception>(action);
            Assert.Equal("стороны должны быть положительные", ex.Message);
        }

        [Fact]
        public void Triangle_IsRectangular_True()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            Triangle triangle = new Triangle(a, b, c);
            // Act
            bool isRectangular = triangle.IsRectangular();
            // Assert
            Assert.True(isRectangular);
        }

        [Fact]
        public void Triangle_IsRectangular_False()
        {
            // Arrange
            double a = 3;
            double b = 3;
            double c = 3;
            Triangle triangle = new Triangle(a, b, c);
            // Act
            bool isRectangular = triangle.IsRectangular();
            // Assert
            Assert.False(isRectangular);
        }

        private double calculateTriangleSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
