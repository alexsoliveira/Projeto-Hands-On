using TesteHandsonCurriculum.Domain.Entity;

namespace TesteHandsonCurriculum.Domain.Interfaces.Repository
{
    public interface ISuspeitoRepository : IRepository<Suspeito>
    {
        Suspeito ObterPorId(int id);
    }
}