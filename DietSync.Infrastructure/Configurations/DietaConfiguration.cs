using DietSync.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DietSync.Infrastructure.Configurations
{
    public class DietaConfiguration : IEntityTypeConfiguration<Dieta>
    {
        public void Configure(EntityTypeBuilder<Dieta> builder)
        {
            builder.ToTable("dietas");
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Id).HasColumnName("id_dieta");

            builder.Property(d => d.NomeDieta)
                .HasColumnName("nome_dieta")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(d => d.TipoDieta)
                .HasColumnName("tipo_dieta")
                .HasMaxLength(255);

            builder.Property(d => d.Calorias)
                .HasColumnName("calorias")
                .HasColumnType("decimal(8,2)");

            builder.Property(d => d.Proteinas)
                .HasColumnName("proteinas")
                .HasColumnType("decimal(8,2)");

            builder.Property(d => d.Carboidratos)
                .HasColumnName("carboidratos")
                .HasColumnType("decimal(8,2)");

            builder.Property(d => d.Gorduras)
                .HasColumnName("gorduras")
                .HasColumnType("decimal(8,2)");

            builder.Property(d => d.DataDieta)
                .HasColumnName("data_dieta")
                .HasColumnType("char(1)")
                .HasMaxLength(1)
                .IsRequired();

            builder.Property(d => d.Refeicao)
                .HasColumnName("refeicao")
                .HasMaxLength(255);

            builder.Property(d => d.Alimentos)
                .HasColumnName("alimentos")
                .HasColumnType("longtext");

            builder.Property(d => d.Quantidade)
                .HasColumnName("quantidade");

            builder.Property(d => d.Observacoes)
                .HasColumnName("observacoes")
                .HasMaxLength(255);

            builder.HasOne(d => d.User)
                .WithMany(u => u.Dietas)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
