namespace ApexCare.Models
{
    public class Technician
    {
        public int TechnicianID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string Company { get; set; }

        public ICollection<TechnicianSkill> TechnicianSkills { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }

}
