using System;
using System.Collections.Generic;
using TesteHandsonCurriculum.Domain.Entity;
using TesteHandsonCurriculum.Domain.Interfaces.Repository;
using TesteHandsonCurriculum.Domain.Interfaces.Services;

namespace TesteHandsonCurriculum.Domain.Services
{
    public class LocalService : ILocalService
    {
        private readonly ILocalRepository _localRepository;
        public LocalService(ILocalRepository localRepository)
        {
            _localRepository = localRepository;
        }        
        public Local ObterPorId(int id)
        {
            return _localRepository.ObterPorId(id);
        }
        public IEnumerable<Local> ObterTodos()
        {
            return _localRepository.ObterTodos();
        }
        public void Dispose()
        {
            _localRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}