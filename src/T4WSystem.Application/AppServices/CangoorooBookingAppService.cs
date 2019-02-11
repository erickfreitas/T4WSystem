using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T4WSystem.Application.Interfaces;
using T4WSystem.Application.ViewModels;
using T4WSystem.Domain.Entities;
using T4WSystem.Domain.Interfaces;

namespace T4WSystem.Application.AppServices
{
    public class CangoorooBookingAppService : ICangoorooBookingAppService
    {
        private readonly ICangoorooBookingService _cangoorooBookingService;

        public CangoorooBookingAppService(ICangoorooBookingService cangoorooBookingService)
        {
            _cangoorooBookingService = cangoorooBookingService;
        }

        public async Task<IEnumerable<HotelViewModel>> GetHotels(CriteriaViewModel criteriaViewModel)
        {
            var criteria = Mapper.Map<CriteriaViewModel, Criteria>(criteriaViewModel);
            criteria.SearchRooms = new List<SearchRoom> { Mapper.Map<CriteriaViewModel, SearchRoom>(criteriaViewModel) };
            return Mapper.Map<IEnumerable<Hotel>, IEnumerable<HotelViewModel>>(await _cangoorooBookingService.GetHotels(criteria));
        }

        public async Task<IEnumerable<HotelViewModel>> GetRamdomHotels(int quantity)
        {
            var criteria = new CriteriaViewModel
            {
                DestinationId = 1010106,
                NumNights = 2,
                CheckinDate = DateTime.Now.AddDays(10).ToString("yyyy-MM-dd"),
                NumAdults = 1,
                ChildAges = new int[] { 5 },
                Quantity = 1
            };
            return await GetHotels(criteria);
        }

        public async Task<IEnumerable<RoomViewModel>> GetRamdomRooms(int quantity)
        {
            var hotels = await GetRamdomHotels(quantity);
            var rooms = new List<RoomViewModel>();
            foreach (var hotel in hotels)
            {
                foreach (var room in hotel.Rooms)
                {
                    if (rooms.Count < quantity)
                    {
                        rooms.Add(room);
                    }
                    else
                    {
                        break;
                    }
                }                
            }
            return rooms.OrderBy(r => r.SellingPricePerRoom.Value).ToList();
        }

        public async Task<IEnumerable<RoomViewModel>> GetRooms(CriteriaViewModel criteriaViewModel)
        {
            var hotels = await GetHotels(criteriaViewModel);
            var rooms = new List<RoomViewModel>();
            foreach (var hotel in hotels)
            {
                foreach (var room in hotel.Rooms)
                {
                    rooms.Add(room);
                }
            }
            return rooms.OrderBy(r => r.SellingPricePerRoom.Value).ToList();
        }
    }
}
