using DietSync.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DietSync.Infrastructure.Configurations
{
    public class EvolucaoConfiguration : IEntityTypeConfiguration<Evolucao>
    {
        public void Configure(EntityTypeBuilder<Evolucao> builder)
        {
            builder.ToTable("evolucaos");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Data)
                .HasColumnName("data")
                .HasColumnType("date")
                .IsRequired();

            builder.Property(e => e.Peso)
                .HasColumnName("peso")
                .HasColumnType("decimal(8,2)");

            builder.Property(e => e.Altura)
                .HasColumnName("altura")
                .HasColumnType("decimal(8,2)");

            builder.Property(e => e.Cintura)
                .HasColumnName("cintura")
                .HasColumnType("decimal(8,2)");

            builder.HasOne(e => e.User)
                .WithMany(u => u.Evolucoes)
                .HasForeignKey(e => e.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
