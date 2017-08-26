using Microsoft.Extensions.DependencyInjection;
using NetCore.EasyApi.Core.IOC;
using Xunit;

namespace Core.UnitTest
{
    public class ServiceDescriptorLoaderTest
    {
        [Fact]
        public void GetAllSuccess()
        {
            var descriptorList = ServiceDescriptorLoader.GetAll();
            Assert.NotNull(descriptorList);
        }
    }
}