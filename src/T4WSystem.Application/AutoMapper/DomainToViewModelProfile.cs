using AutoMapper;
using T4WSystem.Application.ViewModels;
using T4WSystem.Domain.Entities;

namespace T4WSystem.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Hotel, HotelViewModel>();
            CreateMap<Room, RoomViewModel>();
            CreateMap<SellingPricePerRoom, SellingPricePerRoomViewModel>();
            CreateMap<TotalSellingPrice, TotalSellingPriceViewModel>();
        }
    }
}
