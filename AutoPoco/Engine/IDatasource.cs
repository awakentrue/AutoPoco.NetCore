using System;

namespace AutoPoco.Engine
{
    public interface IDatasource
    {
        Object Next(IGenerationContext context);
    }

    public interface IDatasource<T> : IDatasource
    {
        
    }
}
