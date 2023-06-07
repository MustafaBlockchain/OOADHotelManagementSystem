namespace OOADHotelManagementSystem.Models
{
    public class DeparturedBillingInfo
    {
        public int Billing_ID { get; set; }
        public int Room_charge { get; set; }
        public int Misc_charges { get; set; }
        public long Total_cost { get; set; }
        public long CreditCard_No { get; set; }
        public DateTime Payment_Date { get; set; }
        public int Customer_ID { get; set; }
        public long Hotel_ID { get; set; }
    }
}
