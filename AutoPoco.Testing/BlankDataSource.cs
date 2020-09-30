using AutoPoco.Engine;

namespace AutoPoco.Testing
{
    public class BlankDataSource : DatasourceBase<int>
    {
        public override int Next(IGenerationContext context)
        {
            return 0;
        }
    }
}
