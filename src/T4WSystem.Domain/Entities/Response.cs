using System.Collections.Generic;

namespace T4WSystem.Domain.Entities
{
    public class Response
    {
        public string Error { get; set; }
        public string TimeSpan { get; set; }
        public string Token { get; set; }
        public double TotalTime { get; set; }
        public ICollection<Hotel> Hotels { get; set; }
    }
}
