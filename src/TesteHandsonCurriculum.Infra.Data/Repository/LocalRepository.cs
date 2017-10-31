using TesteHandsonCurriculum.Domain.Entity;
using TesteHandsonCurriculum.Domain.Interfaces.Repository;
using TesteHandsonCurriculum.Infra.Data.Context;

namespace TesteHandsonCurriculum.Infra.Data.Repository
{
    public class LocalRepository:Repository<Local>,ILocalRepository
    {
        public LocalRepository(HandsOnAspNETContext context) : base(context)
        {
        }
        public Local ObterPorId(int id)
        {
            return DbSet.Find(id);
        }
    }
}