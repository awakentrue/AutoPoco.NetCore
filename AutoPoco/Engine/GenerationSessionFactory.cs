using AutoPoco.Configuration;
using AutoPoco.Configuration.Providers;

namespace AutoPoco.Engine
{
    public class GenerationSessionFactory : IGenerationSessionFactory
    {
        private IEngineConfiguration mConfig;
        private IEngineConventionProvider mConventionProvider;

        public GenerationSessionFactory(IEngineConfiguration config, IEngineConventionProvider conventionProvider)
        {
            mConfig = config;
            mConventionProvider = conventionProvider;
        }
        
        public IGenerationSession CreateSession(int recursionLimit)
        {
            return new GenerationContext(new GenerationConfiguration(mConfig, mConventionProvider, recursionLimit));
        }

        public IGenerationSession CreateSession()
        {
            // TODO: Need to deep-clone the config
            return CreateSession(5);

        }

    }
}
