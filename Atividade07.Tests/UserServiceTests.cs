using Xunit;

namespace Atividade07.Tests
{
    public class UserServiceTests
    {
        [Fact]
        public void CreateUser_ValidNameAndEmail_ReturnsUserWithSameNameAndEmail()
        {
            // Arrange
            string name = "John Doe";
            string email = "johndoe@example.com";
            User expectedUser = new User(name, email);
            var database = new Database();
            UserService userService = new UserService(database);

            // Act
            userService.SaveUser(expectedUser);


        }
    }
}
