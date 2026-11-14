using System.Collections.Generic;
using TesteHandsonCurriculum.Application.Interfaces;
using TesteHandsonCurriculum.Application.Mappers;
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
            return _suspeitoService.ObterPorId(id).ToViewModel();
        }
        public IEnumerable<SuspeitoViewModel> ObterTodos()
        {
            return _suspeitoService.ObterTodos().ToViewModel();
        }
    }
}
