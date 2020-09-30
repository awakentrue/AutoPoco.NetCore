using AutoPoco.Configuration;
using AutoPoco.Engine;

namespace AutoPoco.Actions
{
    public class ObjectFieldSetFromSourceAction : IObjectAction
    {
        private EngineTypeFieldMember mMember;
        private IDatasource mDatasource;

        public ObjectFieldSetFromSourceAction(EngineTypeFieldMember member, IDatasource source) 
        {
            mMember = member;
            mDatasource = source;
        }

        public void Enact(IGenerationContext context, object target)
        {
            var fieldContext = new GenerationContext(context.Builders, new TypeFieldGenerationContextNode(
                                                                           (TypeGenerationContextNode) context.Node,
                                                                           mMember));
            mMember.FieldInfo.SetValue(target, mDatasource.Next(fieldContext));
        }
    }
}
