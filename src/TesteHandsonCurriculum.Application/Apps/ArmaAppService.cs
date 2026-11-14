using System.Collections.Generic;
using TesteHandsonCurriculum.Application.Interfaces;
using TesteHandsonCurriculum.Application.Mappers;
using TesteHandsonCurriculum.Application.ViewModels;
using TesteHandsonCurriculum.Domain.Interfaces.Services;

namespace TesteHandsonCurriculum.Application.Apps
{
    public class ArmaAppService : IArmaAppService
    {
        private readonly IArmaService _armaService;
        public ArmaAppService(IArmaService armaService)
        {
            _armaService = armaService;
        }
        public ArmaViewModel ObterPorId(int id)
        {
            return _armaService.ObterPorId(id).ToViewModel();
        }
        public IEnumerable<ArmaViewModel> ObterTodos()
        {
            return _armaService.ObterTodos().ToViewModel();
        }
    }
}
