using NSubstitute;

namespace Atividade05.Tests
{
    public class IHttpClientTests
    {
        [Fact]
        public async Task GetAsync_ShouldReturnHttpResponseMessage()
        {
            // Arrange
            var httpClient = Substitute.For<IHttpClient>();
            var expectedResponse = new HttpResponseMessage();

            httpClient.GetAsync(Arg.Any<string>()).Returns(expectedResponse);

            // Act
            var response = await httpClient.GetAsync("http://fakeapi.com/data");

            // Assert
            Assert.Equal(expectedResponse, response);
        }
    }
}
