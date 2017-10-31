using TesteHandsonCurriculum.Domain.Entity;
using TesteHandsonCurriculum.Domain.Interfaces.Repository;
using TesteHandsonCurriculum.Infra.Data.Context;

namespace TesteHandsonCurriculum.Infra.Data.Repository
{
    public class ArmaRepository : Repository<Arma>,IArmaRepository
    {
        public ArmaRepository(HandsOnAspNETContext context) : base(context)
        {
        }
        public Arma ObterPorId(int id)
        {
            return DbSet.Find(id);
        }
    }
}