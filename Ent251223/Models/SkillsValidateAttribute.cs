namespace Ent251223.Models
{
    internal class SkillsValidateAttribute : Attribute
    {
        public string[] Allowed { get; set; }
        public string ErrorMessage { get; set; }
    }
}