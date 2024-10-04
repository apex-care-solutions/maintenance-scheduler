namespace ApexCare.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public string Feedback { get; set; }
        public int Rating { get; set; }

        public int JobID { get; set; }
        public Job Job { get; set; }
    }

}
