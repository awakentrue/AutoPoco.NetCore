using System.Linq;
using NUnit.Framework;
using AutoPoco.Configuration;
using AutoPoco.DataSources;

namespace AutoPoco.Tests.Unit.Configuration
{
    [TestFixture]
    public class MethodInvocationContextTests
    {
        [Test]
        public void AddArgumentSource_AddsArgument()
        {
            MethodInvocationContext context = new MethodInvocationContext();
            context.AddArgumentSource(typeof(RandomStringSource));

            DatasourceFactory factory = context.GetArguments().First();
            Assert.NotNull(factory);
        }

        [Test]
        public void AddArgumentValue_AddsArgument()
        {
            MethodInvocationContext context = new MethodInvocationContext();
            context.AddArgumentValue(5);

            DatasourceFactory factory = context.GetArguments().First();
            Assert.NotNull(factory);
        }
    }
}
