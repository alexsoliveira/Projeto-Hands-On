using System.Collections.Generic;
using AutoMapper;
using TesteHandsonCurriculum.Application.Interfaces;
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
            return Mapper.Map<LocalViewModel>(_localService.ObterPorId(id));
        }
        public IEnumerable<LocalViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<LocalViewModel>>(_localService.ObterTodos());
        }
    }
}