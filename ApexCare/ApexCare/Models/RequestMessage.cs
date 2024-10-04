namespace ApexCare.Models
{
    public class RequestMessage
    {
        public int RequestMessageID { get; set; }
        public string Content { get; set; }

        public int RequestID { get; set; }
        public Request Request { get; set; }
    }
}
