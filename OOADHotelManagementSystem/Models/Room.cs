﻿namespace OOADHotelManagementSystem.Models
{
    public class Room
    {
        public int Room_number { get; set; }
        public string Room_type { get; set; }
        public long Rates { get; set; }
        public string Room_location { get; set; }
        public int NumberOFbeds { get; set; }
        public int? Employee_ID { get; set; }
        public int? Customer_ID { get; set; }
        public long Hotel_ID { get; set; }
        public string Room_condition { get; set; }

        // Composition relationship
        public Room_Condition RoomCondition { get; set; }

        // Composition relationship
        public Hotel Hotel { get; set; }

        // Aggregation relationship
        public Reservations Reservation { get; set; }

        // Aggregation relationship
        public Vendor Vendor { get; set; }
    }
}
