using System.Collections.Generic;
using System.Threading.Tasks;
using T4WSystem.Application.ViewModels;

namespace T4WSystem.Application.Interfaces
{
    public interface ICangoorooBookingAppService
    {
        Task<IEnumerable<HotelViewModel>> GetHotels(CriteriaViewModel criteriaViewModel);
        Task<IEnumerable<HotelViewModel>> GetRamdomHotels(int quantity);
        Task<IEnumerable<RoomViewModel>> GetRooms(CriteriaViewModel criteriaViewModel);
        Task<IEnumerable<RoomViewModel>> GetRamdomRooms(int quantity);
    }
}
