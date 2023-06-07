namespace OOADHotelManagementSystem.Models
{
    public class Vendor
    {

        public string Username { get; set; }
        public string Password { get; set; }
        public string Hotel_Name { get; set; }
        public long Hotel_ID { get; set; }

        // Composition relationship
        public Hotel Hotel { get; set; }

        // Composition relationship
        public VendorRegistration VendorRegistration { get; set; }
    }
}
