namespace ApexCare.Models
{
    public class Service
    {
        public int ServiceID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<PackageService> PackageServices { get; set; }
    }

}
