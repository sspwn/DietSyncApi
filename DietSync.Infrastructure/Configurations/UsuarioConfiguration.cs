using DietSync.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DietSync.Infrastructure.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("usuario");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Name)
                .HasColumnName("name")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(u => u.Meta)
                .HasColumnName("meta")
                .HasMaxLength(255);

            builder.Property(u => u.Sexo)
                .HasColumnName("sexo")
                .HasMaxLength(255);

            builder.Property(u => u.DataNasc)
                .HasColumnName("data_nasc")
                .HasColumnType("date");


            builder.Property(u => u.Peso)
                .HasColumnName("peso")
                .HasColumnType("decimal(8,2)");

            builder.Property(u => u.Altura)
                .HasColumnName("altura")
                .HasColumnType("decimal(8,2)");

            builder.Property(u => u.Email)
                .HasColumnName("email")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(u => u.Password)
                .HasColumnName("password")
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}
