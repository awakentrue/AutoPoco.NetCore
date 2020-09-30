namespace AutoPoco.Configuration.TypeRegistrationActions
{
    public abstract class TypeRegistrationAction : ITypeRegistrationAction
    {
        public ITypeRegistrationAction NextAction { get; set; }

        public abstract void Apply(IEngineConfigurationType type);
        
        void ITypeRegistrationAction.Apply(IEngineConfigurationType type)
        {
            this.Apply(type);
            if (NextAction != null) { NextAction.Apply(type); }
        }
    }
}
