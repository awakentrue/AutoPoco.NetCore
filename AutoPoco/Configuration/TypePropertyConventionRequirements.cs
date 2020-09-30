namespace AutoPoco.Configuration
{
    public class TypePropertyConventionRequirements : TypeMemberConventionRequirements
    {
        public bool IsValid(EngineTypePropertyMember member)
        {
            return IsValidName(member.Name) && IsValidType(member.PropertyInfo.PropertyType);
        }
    }
}
