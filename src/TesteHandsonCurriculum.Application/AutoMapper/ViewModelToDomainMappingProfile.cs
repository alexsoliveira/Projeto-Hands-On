using TesteHandsonCurriculum.Application.ViewModels;
using TesteHandsonCurriculum.Domain.Entity;
using AutoMapper;

namespace TesteHandsonCurriculum.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile :Profile
    {
        protected override void Configure()
        {
            CreateMap<SuspeitoViewModel, Suspeito>();
            CreateMap<LocalViewModel, Local>();
            CreateMap<ArmaViewModel, Arma>();            
        }
    }
}