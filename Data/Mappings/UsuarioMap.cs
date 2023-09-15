using BIManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BIManager.Data.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");


            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.NomeUsuario)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.Email)
               .IsRequired()
               .HasColumnType("NVARCHAR")
               .HasMaxLength(120);

            builder.Property(x => x.Senha)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(30);

            builder.Property(x => x.SenhaAleatoria)
                .IsRequired()
                .HasColumnType("BIT");

            //date management
            builder.Property(x => x.CriadoEm)
                .HasColumnType("SMALLDATETIME")
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(x => x.AtualizadoEm)
                .HasColumnType("SMALLDATETIME")
                .HasDefaultValueSql("GETUTCDATE()");


            // relations
            builder.HasOne(x => x.Funcao)
                .WithMany(x => x.Usuarios)
                .HasConstraintName("FUNCAO_USUARIO");

            builder.HasMany(x => x.BasesDeDados)
                .WithOne(x => x.Usuario)
                .HasConstraintName("USUARIO_BASES_DE_DADOS")
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}