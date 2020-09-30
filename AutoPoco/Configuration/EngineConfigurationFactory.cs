using AutoPoco.Configuration.Providers;
using AutoPoco.Conventions;

namespace AutoPoco.Configuration
{
    public class EngineConfigurationFactory : IEngineConfigurationFactory
    {
        public virtual IEngineConfiguration Create(IEngineConfigurationProvider configurationProvider, IEngineConventionProvider conventionProvider)
        {
            EngineConfiguration configuration = new EngineConfiguration();
            var coreConvention = new DefaultEngineConfigurationProviderLoadingConvention();
            coreConvention.Apply(new EngineConfigurationProviderLoaderContext(configuration, configurationProvider, conventionProvider));
            return configuration;
        }
    }
}
