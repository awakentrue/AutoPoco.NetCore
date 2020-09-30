﻿using NUnit.Framework;
using AutoPoco.Configuration;

namespace AutoPoco.Tests.Integration.Configuration
{
    [TestFixture]
    public class ConfigurationBaseTest
    {
        public EngineConfigurationBuilder Builder
        {
            get;
            private set;
        }

        [SetUp]
        public void CreateBuilder()
        {
            this.Builder = new EngineConfigurationBuilder();
        }      
    }
}
