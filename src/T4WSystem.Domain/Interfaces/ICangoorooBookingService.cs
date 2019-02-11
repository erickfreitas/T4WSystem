using System.Collections.Generic;
using System.Threading.Tasks;
using T4WSystem.Domain.Entities;

namespace T4WSystem.Domain.Interfaces
{
    public interface ICangoorooBookingService
    {
        Task<IEnumerable<Hotel>> GetHotels(Criteria criteria);
    }
}
