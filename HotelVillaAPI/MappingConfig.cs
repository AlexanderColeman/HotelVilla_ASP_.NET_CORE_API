using HotelVillaAPI.Models;
using HotelVillaAPI.Models.Dto;
using AutoMapper;

namespace HotelVillaAPI
{
    public class MappingConfig :Profile
    {

        public MappingConfig()
        {
            CreateMap<Villa,VillaDTO>().ReverseMap();
            CreateMap<Villa,VillaCreateDTO >().ReverseMap();
            CreateMap<Villa,VillaUpdateDTO >().ReverseMap();
        }
    }
}
