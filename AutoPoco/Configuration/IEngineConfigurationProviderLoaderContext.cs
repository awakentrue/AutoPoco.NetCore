using AutoPoco.Configuration.Providers;

namespace AutoPoco.Configuration
{
    public interface IEngineConfigurationProviderLoaderContext
    {
        IEngineConfiguration Configuration { get; }
        IEngineConfigurationProvider ConfigurationProvider { get; }
        IEngineConventionProvider ConventionProvider { get; }
    }
}
