namespace ApexCare.Models
{
    public class Request
    {
        public int RequestID { get; set; }
        public string Type { get; set; } = null!;
        public string Service { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string Priority { get; set; } = null!;

        public int ClientID { get; set; }
        public Client Client { get; set; } = null!;

        public ICollection<RequestMessage> RequestMessages { get; set; } = null!;
        public ICollection<Job> Jobs { get; set; } = null!;
    }


}
