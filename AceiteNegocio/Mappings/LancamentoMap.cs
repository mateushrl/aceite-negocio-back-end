using AceiteNegocio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AceiteNegocio.Mappings
{
    public class LancamentoMap : IEntityTypeConfiguration<Lancamento>
    {
        public void Configure(EntityTypeBuilder<Lancamento> builder)
        {
            builder.ToTable("Lancamento");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);

            builder.Property(p => p.Descricao)
                .HasColumnType("varchar(200)")
                .IsRequired();
            builder.Property(p => p.Data)
                .HasColumnType("datetime")
                .IsRequired();
            builder.Property(p => p.Valor)
                .HasColumnType("decimal(18, 2)")
                .IsRequired();
            builder.Property(p => p.Status)
                .IsRequired();
            builder.Property(p => p.Avulso)
                .IsRequired();
        }
    }
}
