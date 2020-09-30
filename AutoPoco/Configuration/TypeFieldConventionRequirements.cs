namespace AutoPoco.Configuration
{
    public class TypeFieldConventionRequirements : TypeMemberConventionRequirements
    {
        public bool IsValid(EngineTypeFieldMember member)
        {
            return IsValidName(member.Name) && IsValidType(member.FieldInfo.FieldType);
        }
    }
}
