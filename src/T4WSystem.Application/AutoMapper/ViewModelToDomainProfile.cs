using AutoMapper;
using T4WSystem.Application.ViewModels;
using T4WSystem.Domain.Entities;

namespace T4WSystem.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CriteriaViewModel, Criteria>();
            CreateMap<CriteriaViewModel, SearchRoom>();
        }
    }
}
