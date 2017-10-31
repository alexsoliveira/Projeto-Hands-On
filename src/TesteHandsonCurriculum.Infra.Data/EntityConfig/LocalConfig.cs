using System.Data.Entity.ModelConfiguration;
using TesteHandsonCurriculum.Domain.Entity;

namespace TesteHandsonCurriculum.Infra.Data.EntityConfig
{
    public class LocalConfig : EntityTypeConfiguration<Local>
    {
        public LocalConfig()
        {
            HasKey(l => l.LocalCod);
            Property(l => l.LocalCod)
                .HasColumnName("local_cod");
            Property(l => l.LocalNome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("local_nome");
            ToTable("locais");
        }
    }
}