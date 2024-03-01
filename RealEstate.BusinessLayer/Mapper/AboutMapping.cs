using AutoMapper;
using RealEstate.DtoLayer.AboutDtos;
using RealEstate.EntityLayer.Entities;

namespace RealEstate.BusinessLayer.Mapper
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            // ActivityLog entity'sinden ActivityLogDto'ya ve tersi dönüşüm
            CreateMap<About, AboutDto>().ReverseMap();
        }
    }
}
