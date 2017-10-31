using TesteHandsonCurriculum.Domain.Entity;

namespace TesteHandsonCurriculum.Domain.Interfaces.Repository
{
    public interface ILocalRepository : IRepository<Local>
    {
        Local ObterPorId(int id);
    }
}