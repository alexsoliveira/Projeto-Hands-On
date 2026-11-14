using TesteHandsonCurriculum.Application.ViewModels;
using TesteHandsonCurriculum.Domain.Entity;
using AutoMapper;

namespace TesteHandsonCurriculum.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile:Profile
    {
        protected override void Configure()
        {
            CreateMap<Suspeito, SuspeitoViewModel>().MaxDepth(32);
            CreateMap<Local, LocalViewModel>().MaxDepth(32);
            CreateMap<Arma, ArmaViewModel>().MaxDepth(32);            
        }
    }
}