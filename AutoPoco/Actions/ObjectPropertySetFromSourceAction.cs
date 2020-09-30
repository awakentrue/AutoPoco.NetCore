using AutoPoco.Configuration;
using AutoPoco.Engine;

namespace AutoPoco.Actions
{
    public class ObjectPropertySetFromSourceAction : IObjectAction
    {
        private EngineTypePropertyMember mMember;
        private IDatasource mDatasource;

        public ObjectPropertySetFromSourceAction(EngineTypePropertyMember member, IDatasource source)
        {
            mMember = member;
            mDatasource = source;
        }

        public void Enact(IGenerationContext context, object target)
        {
            var propertyContext = new GenerationContext(context.Builders, new TypePropertyGenerationContextNode(
                                                                           (TypeGenerationContextNode)context.Node,
                                                                           mMember));
            mMember.PropertyInfo.SetValue(target, mDatasource.Next(propertyContext), null);
        }
    }
}
