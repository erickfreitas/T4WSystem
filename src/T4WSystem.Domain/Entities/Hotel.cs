using System.Collections.Generic;

namespace T4WSystem.Domain.Entities
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public bool IsRecommended { get; set; }
        public ICollection<Room> Rooms { get; set; }

        public Hotel()
        {
            Rooms = new List<Room>();
        }
    }
}
