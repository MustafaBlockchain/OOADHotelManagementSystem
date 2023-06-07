namespace OOADHotelManagementSystem.Models
{
    public class Plans
    {
        public int Service_ID { get; set; }
        public string Servicename { get; set; }
        public int Servicecost { get; set; }
        public int? Reservation_number { get; set; }
        public long Hotel_ID { get; set; }
    }
}
