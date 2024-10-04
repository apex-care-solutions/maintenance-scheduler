namespace ApexCare.Models
{
    public class PackageService
    {
        public int PackageServiceID { get; set; }

        public int PackageID { get; set; }
        public Package Package { get; set; }

        public int ServiceID { get; set; }
        public Service Service { get; set; }
    }

}
