using Xunit;

namespace Atividade07.Tests
{
    public class DatabaseTests
    {
        [Fact]
        public void SaveUser_ShouldSaveUserToDatabase()
        {

            var database = new Database();
            var user = new User("Teste", "teste@gmail.com");

            database.SaveUser(user);
        }
    }
}
