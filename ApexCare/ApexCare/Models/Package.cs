namespace ApexCare.Models
{
    public class Package
    {
        public int PackageID { get; set; }
        public string Description { get; set; }
        public decimal FlatRate { get; set; }

        public ICollection<Subscription> Subscriptions { get; set; }
        public ICollection<PackagePromotion> PackagePromotions { get; set; }
        public ICollection<PackageService> PackageServices { get; set; }
    }

}
