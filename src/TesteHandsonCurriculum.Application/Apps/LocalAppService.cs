using System.Collections.Generic;
using TesteHandsonCurriculum.Application.Interfaces;
using TesteHandsonCurriculum.Application.Mappers;
using TesteHandsonCurriculum.Application.ViewModels;
using TesteHandsonCurriculum.Domain.Interfaces.Services;

namespace TesteHandsonCurriculum.Application.Apps
{
    public class LocalAppService : ILocalAppService
    {
        private readonly ILocalService _localService;
        public LocalAppService(ILocalService localService)
        {
            _localService = localService;
        }
        public LocalViewModel ObterPorId(int id)
        {
            return _localService.ObterPorId(id).ToViewModel();
        }
        public IEnumerable<LocalViewModel> ObterTodos()
        {
            return _localService.ObterTodos().ToViewModel();
        }
    }
}
