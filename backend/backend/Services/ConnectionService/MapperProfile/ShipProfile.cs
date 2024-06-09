using AutoMapper;
using backend.DTOs;
using backend.Models;

namespace backend.Services.ConnectionService.MapperProfile
{
    public class ShipProfile : Profile
    {
        public ShipProfile()
        {
            CreateMap<ShipCrudDTO, Ship>()
                .ForMember(dest => dest.ShipName, ag => ag.MapFrom(x => x.ShipName))
                .ForMember(dest => dest.ShipClassId, ag => ag.MapFrom(x => x.ShipClassId))
                .ForMember(dest => dest.Speed, ag => ag.MapFrom(x => x.Speed))
                .ForMember(dest => dest.ShipClass, ag => ag.MapFrom(x => x.ShipClass))
                .ReverseMap();
        }
    }
}
