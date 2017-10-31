using TesteHandsonCurriculum.Domain.Entity;
using TesteHandsonCurriculum.Domain.Interfaces.Repository;
using TesteHandsonCurriculum.Infra.Data.Context;

namespace TesteHandsonCurriculum.Infra.Data.Repository
{
    public class SuspeitoRepository:Repository<Suspeito>,ISuspeitoRepository
    {
        public SuspeitoRepository(HandsOnAspNETContext context) : base(context)
        {
        }
        public Suspeito ObterPorId(int id)
        {
            return DbSet.Find(id);
        }
    }
}