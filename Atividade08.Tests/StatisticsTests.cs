
using System;
using System.Collections.Generic;
using Xunit;

namespace Atividade08.Tests
{
    public class StatisticsTests
    {
        [Fact]
        public void CalculateAverage_ValidNumbers_ReturnsAverage()
        {
            // Arrange
            var statistics = new Statistics();
            var numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Act
            var result = statistics.CalculateAverage(numbers);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void CalculateAverage_EmptyList_ThrowsArgumentException()
        {
            // Arrange
            var statistics = new Statistics();
            var numbers = new List<int>();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => statistics.CalculateAverage(numbers));
        }

        [Fact]
        public void CalculateAverage_NullList_ThrowsArgumentException()
        {
            // Arrange
            var statistics = new Statistics();
            List<int> numbers = null;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => statistics.CalculateAverage(numbers));
        }
    }
}
