using Megaphone.Standard.Services;
using System.Threading.Tasks;
using Xunit;

namespace Megaphone.Standard.Tests
{
    public class InMemoryStorageServiceTests
    {
        [Fact]
        public void MakeInMemoryStorageService()
        {
            IStorageService<string> service = new InMemoryStorageService<string>();
        }

        [Fact]
        public async Task SetData()
        {
            IStorageService<string> service = new InMemoryStorageService<string>();
            await service.SetAsync("google.com", "<html></html>");
        }

        [Fact]
        public async Task GetData()
        {
            IStorageService<string> service = new InMemoryStorageService<string>();
            await service.SetAsync("google.com", "<html></html>");

            var content = await service.GetAsync("google.com");            
            Assert.True(content == "<html></html>");
        }
    }
}
