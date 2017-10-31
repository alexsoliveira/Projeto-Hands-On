using System;
using System.Collections.Generic;
using TesteHandsonCurriculum.Domain.Entity;

namespace TesteHandsonCurriculum.Domain.Interfaces.Services
{
    public interface IArmaService : IDisposable
    {
        Arma ObterPorId(int id);
        IEnumerable<Arma> ObterTodos();
    }
}