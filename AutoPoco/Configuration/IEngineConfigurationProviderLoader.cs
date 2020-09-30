namespace AutoPoco.Configuration
{
    public interface IEngineConfigurationProviderLoader
    {
        void Apply(IEngineConfigurationProviderLoaderContext context);
    }
}
