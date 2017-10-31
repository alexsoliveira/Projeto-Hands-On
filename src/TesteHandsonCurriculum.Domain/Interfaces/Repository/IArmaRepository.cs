using TesteHandsonCurriculum.Domain.Entity;

namespace TesteHandsonCurriculum.Domain.Interfaces.Repository
{
    public interface IArmaRepository : IRepository<Arma>
    {
        Arma ObterPorId(int id);
    }
}