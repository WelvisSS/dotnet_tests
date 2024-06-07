using NSubstitute;
using Xunit;
namespace Atividade06.Tests
{
    public class PointTests
    {
        [Fact]
        public void DistanceTo_ReturnsCorrectDistance()
        {
            var point1 = new Point(0, 0);
            var point2 = new Point(3, 4);
            var expectedDistance = 5;

            var actualDistance = point1.DistanceTo(point2);

            Assert.Equal(expectedDistance, actualDistance);
        }

        [Fact]
        public void DistanceTo_ThrowsArgumentNullException_WhenOtherIsNull()
        {
            var point = new Point(0, 0);
            Assert.Throws<ArgumentNullException>(() => point.DistanceTo(null));
        }
    }

}

