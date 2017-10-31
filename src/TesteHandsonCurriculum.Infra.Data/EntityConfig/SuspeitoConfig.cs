using System.Data.Entity.ModelConfiguration;
using TesteHandsonCurriculum.Domain.Entity;

namespace TesteHandsonCurriculum.Infra.Data.EntityConfig
{
    public class SuspeitoConfig : EntityTypeConfiguration<Suspeito>
    {
        public SuspeitoConfig()
        {
            HasKey(s => s.SuspeitoCod);
            Property(s => s.SuspeitoCod)
                .HasColumnName("suspeito_cod");
            Property(s => s.SuspeitoNome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("suspeito_nome");                        
            ToTable("suspeitos");
        }
    }
}