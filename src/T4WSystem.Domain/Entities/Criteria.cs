using System.Collections.Generic;

namespace T4WSystem.Domain.Entities
{
    public class Criteria
    {
        public int DestinationId { get; set; }
        public int NumNights { get; set; }
        public string CheckinDate { get; set; }
        public string MainPaxCountryCodeNationality { get; set; }
        public ICollection<SearchRoom> SearchRooms { get; set; }        
    }
}
