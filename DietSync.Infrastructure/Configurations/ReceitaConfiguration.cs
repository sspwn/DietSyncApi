using DietSync.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DietSync.Infrastructure.Configurations
{
    public class ReceitaConfiguration : IEntityTypeConfiguration<Receita>
    {
        public void Configure(EntityTypeBuilder<Receita> builder)
        {
            builder.ToTable("receita");
            builder.HasKey(r => r.Id);

            builder.Property(r => r.NomeReceita)
                .HasColumnName("nome_receita")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(r => r.Ingredientes)
                .HasColumnName("ingredientes")
                .HasColumnType("text");

            builder.Property(r => r.ModoPreparo)
                .HasColumnName("modo_preparo")
                .HasColumnType("longtext");

            builder.Property(r => r.Calorias)
                .HasColumnName("calorias")
                .HasColumnType("decimal(8,2)");

            builder.Property(r => r.Proteinas)
                .HasColumnName("proteinas")
                .HasColumnType("decimal(8,2)");

            builder.Property(r => r.Carboidratos)
                .HasColumnName("carboidratos")
                .HasColumnType("decimal(8,2)");

            builder.Property(r => r.Gorduras)
                .HasColumnName("gorduras")
                .HasColumnType("decimal(8,2)");

            builder.HasOne(r => r.User)
                .WithMany(u => u.Receitas)
                .HasForeignKey(r => r.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
