namespace ApexCare.Models
{
    public class TechnicianSkill
    {
        public int TechnicianSkillID { get; set; }

        public int TechnicianID { get; set; }
        public Technician Technician { get; set; }

        public int SkillID { get; set; }
        public Skill Skill { get; set; }
    }

}
