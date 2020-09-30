using System;
using NUnit.Framework;
using AutoPoco.DataSources;

namespace AutoPoco.Tests.Unit.DataSources
{
    [TestFixture]
    public class FirstNameSourceTests
    {
        [Test]
        public void Next_ReturnsString()
        {
            FirstNameSource source = new FirstNameSource();
            String name = source.Next(null);

            Assert.NotNull(name);
        }
    }
}
