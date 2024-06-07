using Xunit;
namespace Atividade09.Tests
{
    public class ItemTests
    {
        [Fact]
        public void Item_Should_Set_Name_Correctly()
        {
            // Arrange
            var expectedName = "Sample Item";

            // Act
            var item = new Item(expectedName);

            // Assert
            Assert.Equal(expectedName, item.Name);
        }

        [Fact]
        public void Item_Name_Should_Be_Null_If_Empty_String()
        {
            // Arrange
            var expectedName = string.Empty;

            // Act
            var item = new Item(expectedName);

            // Assert
            Assert.Equal(expectedName, item.Name);
        }

        [Fact]
        public void Item_Name_Should_Throw_Exception_If_Null()
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentNullException>(() => new Item(null));
        }
    }

}
