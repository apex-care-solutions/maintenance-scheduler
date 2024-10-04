namespace ApexCare.Models
{
    public class JobStatus
    {
        public int JobStatusID { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public DateTime Timestamp { get; set; }

        public int JobID { get; set; }
        public Job Job { get; set; }
    }

}
