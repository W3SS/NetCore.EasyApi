using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using NetCore.EasyApi.Core.Extensions;

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

            ServiceDescriptorLoader.GetAll().ForEach(descriptor =>
            {
                var registerBuilder = builder.RegisterType(descriptor.ImplementationType)
                    .As(descriptor.ServiceType);
                
                switch (descriptor.Lifetime)
                {
                    case ServiceLifetime.Transient:
                        //can be remove, because of the autofac default lifetime is transient
                        registerBuilder.InstancePerDependency();
                        break;
                    case ServiceLifetime.Singleton:
                        registerBuilder.SingleInstance();
                        break;
                    case ServiceLifetime.Scoped:
                        registerBuilder.InstancePerLifetimeScope();
                        break;
                    default:
                        break;
                }
                
            });

            return builder.Build();
        }
    }
}