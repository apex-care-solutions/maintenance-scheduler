namespace ApexCare.Models
{
    public class PackagePromotion
    {
        public int PackagePromotionID { get; set; }
        public decimal Discount { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public int PackageID { get; set; }
        public Package Package { get; set; }
    }

}
