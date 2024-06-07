using NSubstitute;

namespace Atividade05.Tests
{
    public class HttpClientWrapperTests
    {
        [Fact]
        public async Task GetAsync_ShouldCallHttpClientGetAsync()
        {
            // Arrange
            var httpClient = Substitute.For<HttpClient>();
            var wrapper = new HttpClientWrapper(httpClient);
            var url = "http://fakeapi.com/data";

            // Act
            await wrapper.GetAsync(url);

            // Assert
            await httpClient.Received(1).GetAsync(url);
        }
    }

}
