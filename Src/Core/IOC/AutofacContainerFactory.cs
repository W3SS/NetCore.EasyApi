using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace NetCore.EasyApi.Core.IOC
{
    public class AutofacContainerFactory
    {
        public AutofacContainerFactory()
        {
        }

        public static IContainer Get(IServiceCollection serviceCollection)
        {
            var builder = new ContainerBuilder();
            builder.Populate(serviceCollection);

            return builder.Build();
        }
    }
}