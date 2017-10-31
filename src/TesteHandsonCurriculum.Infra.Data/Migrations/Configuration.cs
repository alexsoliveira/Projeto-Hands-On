using System.Data.Entity.Migrations;
using TesteHandsonCurriculum.Infra.Data.Context;

namespace TesteHandsonCurriculum.Infra.Data.Migrations
{    
    internal sealed class Configuration : DbMigrationsConfiguration<HandsOnAspNETContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HandsOnAspNETContext context)
        {
            
        }
    }
}