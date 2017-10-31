using System.Collections.Generic;
using TesteHandsonCurriculum.Application.ViewModels;

namespace TesteHandsonCurriculum.Application.Interfaces
{
    public interface IArmaAppService
    {
        ArmaViewModel ObterPorId(int id);
        IEnumerable<ArmaViewModel> ObterTodos();
    }
}