namespace AutoPoco.Configuration
{
    public interface ITypeRegistrationAction
    {
        void Apply(IEngineConfigurationType type);
    }
}
