using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using NetCore.EasyApi.Core.IOC;
using Xunit;

namespace Core.UnitTest
{
    public class AutofacContainerFactoryTest
    {
        [Fact]
        public void GetSuccess()
        {
            var container = AutofacContainerFactory.Get(new ServiceCollection());
            Assert.NotNull(container);
        }
    }
}