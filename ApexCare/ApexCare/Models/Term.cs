namespace ApexCare.Models
{
    public class Term
    {
        public int TermID { get; set; }
        public string TermLength { get; set; }
        public decimal RelativeRate { get; set; }

        public ICollection<Subscription> Subscriptions { get; set; }
    }

}
