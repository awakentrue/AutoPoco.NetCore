using System.Collections.Generic;

namespace AutoPoco.Configuration.Providers
{
    public interface IEngineConfigurationTypeMemberProvider
    {
        EngineTypeMember GetConfigurationMember();

        IEnumerable<IEngineConfigurationDatasource> GetDatasources();
    }
}
