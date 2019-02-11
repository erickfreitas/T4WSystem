namespace T4WSystem.Domain.Entities
{
    public class Room
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
        public SellingPricePerRoom SellingPricePerRoom { get; set; }
        public TotalSellingPrice TotalSellingPrice { get; set; }
    }
}
