using HotelVilla_Web.Models;
using HotelVilla_Web.Models.Dto;
using AutoMapper;

namespace HotelVilla_Web
{
    public class MappingConfig :Profile
    {

        public MappingConfig()
        {
            CreateMap<VillaDTO, VillaCreateDTO>().ReverseMap();
            CreateMap<VillaDTO, VillaUpdateDTO>().ReverseMap();
            CreateMap<VillaNumberDTO, VillaNumberCreateDTO>().ReverseMap();
            CreateMap<VillaNumberDTO, VillaNumberUpdateDTO>().ReverseMap();
        }
    }
}
