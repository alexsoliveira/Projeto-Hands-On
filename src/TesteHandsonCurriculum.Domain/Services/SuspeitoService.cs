using System;
using System.Collections.Generic;
using TesteHandsonCurriculum.Domain.Entity;
using TesteHandsonCurriculum.Domain.Interfaces.Repository;
using TesteHandsonCurriculum.Domain.Interfaces.Services;

namespace TesteHandsonCurriculum.Domain.Services
{
    public class SuspeitoService : ISuspeitoService
    {
        private readonly ISuspeitoRepository _suspeitoRepository;
        public SuspeitoService(ISuspeitoRepository suspeitoRepository)
        {
            _suspeitoRepository = suspeitoRepository;
        }
        public Suspeito ObterPorId(int id)
        {
            return _suspeitoRepository.ObterPorId(id);
        }
        public IEnumerable<Suspeito> ObterTodos()
        {
            return _suspeitoRepository.ObterTodos();
        }
        public void Dispose()
        {
            _suspeitoRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}