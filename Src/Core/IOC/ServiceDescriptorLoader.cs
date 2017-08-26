using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

namespace NetCore.EasyApi.Core.IOC
{
    internal class ServiceDescriptorLoader
    {
        internal static IEnumerable<ServiceDescriptor> GetAll()
        {
            return new List<ServiceDescriptor>();
        }
    }
}