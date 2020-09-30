using System.Collections.Generic;

namespace AutoPoco.Configuration.Providers
{
    public interface IEngineConfigurationProvider
    {
        /// <summary>
        /// Gets the configuration types from the provider
        /// </summary>
        /// <returns></returns>
        IEnumerable<IEngineConfigurationTypeProvider> GetConfigurationTypes();
    }
}
