namespace AutoPoco.Engine
{
    public class RootGenerationContextNode : IGenerationContextNode
    {
        public IGenerationContextNode Parent
        {
            get { return null; }
        }
        public GenerationTargetTypes ContextType
        {
            get { return GenerationTargetTypes.Root; }
        }
    }
}
