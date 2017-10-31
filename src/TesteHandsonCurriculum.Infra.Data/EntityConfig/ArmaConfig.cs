using System.Data.Entity.ModelConfiguration;
using TesteHandsonCurriculum.Domain.Entity;

namespace TesteHandsonCurriculum.Infra.Data.EntityConfig
{
    public class ArmaConfig : EntityTypeConfiguration<Arma>
    {
        public ArmaConfig()
        {
            HasKey(a => a.ArmaCod);
            Property(a => a.ArmaCod)
                .HasColumnName("arma_cod");
            Property(a => a.ArmaNome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("arma_nome");
            ToTable("armas");
        }
    }
}