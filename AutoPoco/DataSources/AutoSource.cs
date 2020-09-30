using AutoPoco.Engine;

namespace AutoPoco.DataSources
{
    public class AutoSource<T> : DatasourceBase<T>
    {
        public override T Next(IGenerationContext context)
        {
            return context.Single<T>().Get();
        }
    }
}
