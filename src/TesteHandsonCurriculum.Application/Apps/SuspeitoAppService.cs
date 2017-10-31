using System.Collections.Generic;
using AutoMapper;
using TesteHandsonCurriculum.Application.Interfaces;
using TesteHandsonCurriculum.Application.ViewModels;
using TesteHandsonCurriculum.Domain.Interfaces.Services;

namespace TesteHandsonCurriculum.Application.Apps
{
    public class SuspeitoAppService : ISuspeitoAppService
    {
        private readonly ISuspeitoService _suspeitoService;        
        public SuspeitoAppService(ISuspeitoService suspeitoService)
        {
            _suspeitoService = suspeitoService;            
        }
        public SuspeitoViewModel ObterPorId(int id)
        {
            return Mapper.Map<SuspeitoViewModel>(_suspeitoService.ObterPorId(id));
        }
        public IEnumerable<SuspeitoViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<SuspeitoViewModel>>(_suspeitoService.ObterTodos());
        }
    }
}