using AutoMapper;

namespace Repository.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ReturnFileDTO, Archive>()
                .ForMember(x => x.Date, opt => opt.MapFrom(x => DateTime.Now))
                .ForMember(x => x.ContractName, opt => opt.MapFrom(x => x.ContractName))
                .ForMember(x => x.ExecutorsEmail, opt => opt.Ignore())
                .ForMember(x => x.ExecutorsFullName, opt => opt.Ignore())
                .ForMember(x => x.FilePath, opt => opt.Ignore());
        }
    }
}
