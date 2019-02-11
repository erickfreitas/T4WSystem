using System.Collections.Generic;

namespace T4WSystem.Application.ViewModels
{
    public class HotelViewModel
    {
        public int HotelId { get; set; }
        public bool IsRecommended { get; set; }
        public ICollection<RoomViewModel> Rooms { get; set; }
    }
}
