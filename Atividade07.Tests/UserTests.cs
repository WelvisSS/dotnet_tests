using Xunit;

namespace Atividade07.Tests
{
    public class UserTests
    {
        [Fact]
        public void SaveUser_ValidUser_SavesUser()
        {
            // Arrange
            var user = new User
            (
                "John Doe",
                "john.doe@example.com"
            );
            var dbMock = new Mock<IDatabase>();
            var userService = new UserService(dbMock.Object);

            // Act
            userService.SaveUser(user);

            // Assert
            dbMock.Verify(db => db.SaveUser(user), Times.Once);
        }

        [Fact]
        public void SaveUser_NullName_ThrowsArgumentException()
        {
            // Arrange
            var user = new User
            (
                null,
                "john.doe@example.com"
            );
            var dbMock = new Mock<IDatabase>();
            var userService = new UserService(dbMock.Object);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => userService.SaveUser(user));
        }

        [Fact]
        public void SaveUser_NullEmail_ThrowsArgumentException()
        {
            // Arrange
            var user = new User
            (
                "John Doe",
                null
            );
            var dbMock = new Mock<IDatabase>();
            var userService = new UserService(dbMock.Object);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => userService.SaveUser(user));
        }

        [Fact]
        public void SaveUser_EmptyName_ThrowsArgumentException()
        {
            // Arrange
            var user = new User
            (
               "",
               "john.doe@example.com"
            );
            var dbMock = new Mock<IDatabase>();
            var userService = new UserService(dbMock.Object);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => userService.SaveUser(user));
        }

        [Fact]
        public void SaveUser_EmptyEmail_ThrowsArgumentException()
        {
            // Arrange
            var user = new User
            (
                "John Doe",
                 ""
            );
            var dbMock = new Mock<IDatabase>();
            var userService = new UserService(dbMock.Object);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => userService.SaveUser(user));
        }
    }
}
