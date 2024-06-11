using AutoMapper;
using backend.DTOs;
using backend.Models;

namespace backend.Services.ConnectionService.MapperProfile
{
    public class GraphDataProfile : Profile
    {
        public GraphDataProfile()
        {
            CreateMap<GraphDataDTO, GraphData>()
                .ForMember(dest => dest.Id, ag => ag.MapFrom(x => x.GraphDataId))
                .ForMember(dest => dest.PointName, ag => ag.MapFrom(x => x.PointName))
                .ReverseMap();
        }
    }
}
