using Xunit;

namespace Atividade07.Tests
{
    public class IDatabaseTests
    {
        [Fact]
        public void SaveUser_ShouldSaveUser()
        {
            // Arrange
            IDatabase database = new Database();
            User user = new User("Teste", "teste@gmail.com");

            // Act
            database.SaveUser(user);

            // Assert
            // Add your assertions here to verify that the user was saved correctly
        }
    }
}
