using TesteHandsonCurriculum.Application.ViewModels;
using TesteHandsonCurriculum.Domain.Entity;
using AutoMapper;

namespace TesteHandsonCurriculum.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile:Profile
    {
        protected override void Configure()
        {
            CreateMap<Suspeito, SuspeitoViewModel>();
            CreateMap<Local, LocalViewModel>();
            CreateMap<Arma, ArmaViewModel>();            
        }
    }
}