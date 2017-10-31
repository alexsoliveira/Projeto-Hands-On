using System;
using System.Collections.Generic;
using TesteHandsonCurriculum.Domain.Entity;
using TesteHandsonCurriculum.Domain.Interfaces.Repository;
using TesteHandsonCurriculum.Domain.Interfaces.Services;

namespace TesteHandsonCurriculum.Domain.Services
{
    public class ArmaService : IArmaService
    {
        private readonly IArmaRepository _armaRepository;
        public ArmaService(IArmaRepository armaRepository)
        {
            _armaRepository = armaRepository;
        }        
        public Arma ObterPorId(int id)
        {
            return _armaRepository.ObterPorId(id);
        }
        public IEnumerable<Arma> ObterTodos()
        {
            return _armaRepository.ObterTodos();
        }        
        public void Dispose()
        {
            _armaRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}