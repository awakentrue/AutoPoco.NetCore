using System;
using NUnit.Framework;
using AutoPoco.Configuration;
using AutoPoco.Testing;

namespace AutoPoco.Tests.Unit.Configuration
{
    [TestFixture]
    public class EngineConfigurationTests
    {
        [Test]
        public void RegisterType_TypeAlreadyRegistered_Throws_Exception()
        {
            EngineConfiguration configuration = new EngineConfiguration();
            configuration.RegisterType(typeof(SimpleUser));

            Assert.Throws<ArgumentException>(() =>
            {
                configuration.RegisterType(typeof(SimpleUser));
            });
        }
    }
}
