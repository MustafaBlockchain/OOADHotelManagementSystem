namespace OOADHotelManagementSystem.Models
{
    public class Reservations
    {
        public int Reservation_number { get; set; }
        public int Customer_ID { get; set; }
        public DateTime Check_In { get; set; }
        public DateTime Check_Out { get; set; }
        public string Status_current { get; set; }
        public int NumberOFguests { get; set; }
        public DateTime Reservation_date { get; set; }
        public int Room_number { get; set; }
        public long Hotel_ID { get; set; }
        public int Employee_ID { get; set; }

        // Association relationship
        public Customer Customer { get; set; }

        // Association relationship
        public Employee ReceptionStaff { get; set; }

        // Association relationship
        public Vendor Vendor { get; set; }

        // Association relationship
        public Room Room { get; set; }
    }
}
