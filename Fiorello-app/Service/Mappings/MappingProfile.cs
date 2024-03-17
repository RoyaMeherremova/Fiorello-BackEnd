using AutoMapper;
using Domain.Models;
using Service.DTOs;

namespace Service.Mappings
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<Slider, SliderDto>().ReverseMap();

        }

    }


    
}
