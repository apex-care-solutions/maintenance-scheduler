namespace ApexCare.Models
{
    public class Job
    {
        public int JobID { get; set; }

        public int RequestID { get; set; }
        public Request Request { get; set; }

        public int TechnicianID { get; set; }
        public Technician Technician { get; set; }

        public ICollection<JobStatus> JobStatuses { get; set; }
        public Review Review { get; set; }
    }

}
