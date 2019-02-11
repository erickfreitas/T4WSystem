namespace T4WSystem.Application.ViewModels
{
    public class RoomViewModel
    {
        public string BoardDescription { get; set; }
        public string CancellationPolicies { get; set; }
        public int[] ChildAges { get; set; }
        public string CustomFields { get; set; }
        public int Id { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsPrePayment { get; set; }
        public string MoreInformation { get; set; }
        public int NumAdults { get; set; }
        public bool PayDirectToHotel { get; set; }
        public int Quantity { get; set; }
        public string RoomDescription { get; set; }
        public SellingPricePerRoomViewModel SellingPricePerRoom { get; set; }
        public TotalSellingPriceViewModel TotalSellingPrice { get; set; }
    }
}