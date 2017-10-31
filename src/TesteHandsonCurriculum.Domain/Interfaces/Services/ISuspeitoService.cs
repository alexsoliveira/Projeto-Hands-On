using System;
using System.Collections.Generic;
using TesteHandsonCurriculum.Domain.Entity;

namespace TesteHandsonCurriculum.Domain.Interfaces.Services
{
    public interface ISuspeitoService : IDisposable
    {
        Suspeito ObterPorId(int id);
        IEnumerable<Suspeito> ObterTodos();
    }
}