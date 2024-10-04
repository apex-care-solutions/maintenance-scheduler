namespace ApexCare.Models
{
    public class Skill
    {
        public int SkillID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public ICollection<TechnicianSkill> TechnicianSkills { get; set; }
    }

}
