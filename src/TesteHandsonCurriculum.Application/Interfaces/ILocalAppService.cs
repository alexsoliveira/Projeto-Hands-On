using System.Collections.Generic;
using TesteHandsonCurriculum.Application.ViewModels;

namespace TesteHandsonCurriculum.Application.Interfaces
{
    public interface ILocalAppService
    {
        LocalViewModel ObterPorId(int id);
        IEnumerable<LocalViewModel> ObterTodos();
    }
}