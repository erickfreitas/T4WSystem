using AutoMapper;

namespace T4WSystem.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelProfile>();
                x.AddProfile<ViewModelToDomainProfile>();
            });
        }
    }
}
