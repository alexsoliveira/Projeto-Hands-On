using System.Collections.Generic;
using AutoMapper;
using TesteHandsonCurriculum.Application.Interfaces;
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
            return Mapper.Map<ArmaViewModel>(_armaService.ObterPorId(id));
        }
        public IEnumerable<ArmaViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<ArmaViewModel>>(_armaService.ObterTodos());
        }
    }
}