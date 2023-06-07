namespace OOADHotelManagementSystem.Models
{
    public class Room_Condition
    {
        public int Room_number { get; set; }
        public string Clean_Room { get; set; }
        public string Dirty_Room { get; set; }
        public int? Customer_ID { get; set; }
        public long Hotel_ID { get; set; }
    }
}
