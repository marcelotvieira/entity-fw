using BIManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BIManager.Data.Mappings
{
    public class ConsultaMap : IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            builder.ToTable("Consulta");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.ConsultaSQL)
                .IsRequired()
                .HasColumnType("NVARCHAR(MAX)");

            builder.Property(x => x.CompativelComPeriodo)
                .IsRequired()
                .HasColumnType("BIT")
                .HasDefaultValue(false);

            builder.Property(x => x.ChaveEixoXDoGrafico)
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.ChaveEixoYDoGrafico)
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);
        }
    }
}