using DietSync.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DietSync.Infrastructure.Configurations
{
    public class TreinoConfiguration : IEntityTypeConfiguration<Treino>
    {
        public void Configure(EntityTypeBuilder<Treino> builder)
        {
            builder.ToTable("treino");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Data)
                .HasColumnName("data")
                .HasColumnType("date");

            builder.Property(t => t.Tipo)
                .HasColumnName("tipo")
                .HasMaxLength(255);

            builder.Property(t => t.Exercicios)
                .HasColumnName("exercicios")
                .HasColumnType("text");

            builder.Property(t => t.Repeticoes)
                .HasColumnName("repeticoes");

            builder.Property(t => t.Series)
                .HasColumnName("series");

            builder.Property(t => t.Objetivo)
                .HasColumnName("objetivo")
                .HasMaxLength(255);

            builder.Property(t => t.Duracao)
                .HasColumnName("duracao")
                .HasMaxLength(255);

            builder.Property(t => t.Frequencia)
                .HasColumnName("frequencia")
                 .HasMaxLength(255);

            builder.Property(t => t.NomeTreino)
                .HasColumnName("nome_treino")
                .HasMaxLength(255)
                .IsRequired();

            builder.HasOne(t => t.User)
                .WithMany(u => u.Treinos)
                .HasForeignKey(t => t.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
