using BIManage.Models;
using BIManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BIManager.Data.Mappings
{
    public class BaseDeDadosMap : IEntityTypeConfiguration<BaseDeDados>
    {

        public void Configure(EntityTypeBuilder<BaseDeDados> builder)
        {
            builder.ToTable("BaseDeDados");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.UrlConexao)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(255);

            //relations
            builder.HasMany(x => x.Consultas)
                .WithMany(x => x.BasesDeDados)
                .UsingEntity<Dictionary<string, object>>(
                    "Consultas_BaseDeDados",
                    b => b.HasOne<Consulta>()
                        .WithMany()
                        .HasForeignKey("BaseDeDadosId")
                        .HasConstraintName("BASEDEDADOS_CONSULTA")
                        .OnDelete(DeleteBehavior.ClientSetNull),
                    c => c.HasOne<BaseDeDados>()
                        .WithMany()
                        .HasForeignKey("ConsultaID")
                        .HasConstraintName("CONSULTA_BASEDEDADOS")
                        .OnDelete(DeleteBehavior.ClientSetNull));

            // date management
            builder.Property(x => x.CriadoEm)
                .HasColumnType("SMALLDATETIME")
                .HasDefaultValueSql("GETUTCDATE()");


            builder.Property(x => x.AtualizadoEm)
                .HasColumnType("SMALLDATETIME")
                .HasDefaultValueSql("GETUTCDATE()");

        }
    }
}