namespace ApexCare.Models
{
    public class Subscription
    {
        public int SubscriptionID { get; set; }
        public DateTime DateSubscribed { get; set; }

        public int ClientID { get; set; }
        public Client Client { get; set; }

        public int TermID { get; set; }
        public Term Term { get; set; }

        public int PackageID { get; set; }
        public Package Package { get; set; }
    }

}
