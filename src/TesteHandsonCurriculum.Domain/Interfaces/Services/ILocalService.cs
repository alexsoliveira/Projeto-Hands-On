using System;
using System.Collections.Generic;
using TesteHandsonCurriculum.Domain.Entity;

namespace TesteHandsonCurriculum.Domain.Interfaces.Services
{
    public interface ILocalService : IDisposable
    {
        Local ObterPorId(int id);
        IEnumerable<Local> ObterTodos();
    }
}