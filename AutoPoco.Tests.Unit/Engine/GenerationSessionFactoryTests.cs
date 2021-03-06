﻿using NUnit.Framework;
using AutoPoco.Configuration;
using AutoPoco.Engine;
using AutoPoco.Configuration.Providers;

namespace AutoPoco.Tests.Unit.Engine
{
    [TestFixture]
    public class GenerationSessionFactoryTests
    {
        [Test]
        public void CreateSession_EmptyConfig_ReturnsSession()
        {
            IEngineConventionProvider conventionProvider = new EngineConventionConfiguration();
            GenerationSessionFactory config = new GenerationSessionFactory(new EngineConfiguration(), conventionProvider);
            IGenerationSession session = config.CreateSession();

            Assert.NotNull(session);
        }
    }
}
