using System.Collections.Generic;
using TesteHandsonCurriculum.Application.ViewModels;

namespace TesteHandsonCurriculum.Application.Interfaces
{
    public interface ISuspeitoAppService
    {
        SuspeitoViewModel ObterPorId(int id);
        IEnumerable<SuspeitoViewModel> ObterTodos();
    }
}