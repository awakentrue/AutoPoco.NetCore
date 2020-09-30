namespace AutoPoco.Testing
{
    public class SimpleDerivedClass : SimpleBaseClass, ISimpleInterface
    {
        public string Name
        {
            get;
            set;
        }

        public override string BaseVirtualProperty
        {
            get;
            set;
        }
    }
}
