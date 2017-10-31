using TesteHandsonCurriculum.Domain.Entity;
using TesteHandsonCurriculum.Infra.Data.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TesteHandsonCurriculum.Infra.Data.Context
{
    public class HandsOnAspNETContext: DbContext
    {
        public HandsOnAspNETContext():base("DefaultConnection")
        {

        }        
        public DbSet<Suspeito> Suspeitos { get; set; }
        public DbSet<Local> Locais { get; set; }
        public DbSet<Arma> Armas { get; set; }            
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            // general custom context properties
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));            
            modelBuilder.Configurations.Add(new SuspeitoConfig());
            modelBuilder.Configurations.Add(new LocalConfig());
            modelBuilder.Configurations.Add(new ArmaConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}