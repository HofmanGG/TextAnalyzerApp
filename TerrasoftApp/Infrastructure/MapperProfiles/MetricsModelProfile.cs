using AutoMapper;
using BusinessLogic.DTOs;
using TextAnalyzerApp.Infrastructure.Models;

namespace TextAnalyzerApp.Infrastructure.MapperProfiles
{
    public class MetricsModelProfile : Profile
    {
        public MetricsModelProfile()
        {
            CreateMap<MetricsDto, MetricsModel>();
        }
    }
}
