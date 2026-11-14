using TesteHandsonCurriculum.Application.ViewModels;
using TesteHandsonCurriculum.Domain.Entity;
using AutoMapper;

namespace TesteHandsonCurriculum.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile :Profile
    {
        protected override void Configure()
        {
            CreateMap<SuspeitoViewModel, Suspeito>().MaxDepth(32);
            CreateMap<LocalViewModel, Local>().MaxDepth(32);
            CreateMap<ArmaViewModel, Arma>().MaxDepth(32);            
        }
    }
}