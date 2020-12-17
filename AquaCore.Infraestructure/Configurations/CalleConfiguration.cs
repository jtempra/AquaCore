using AquaCore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaCore.Infraestructure.Configurations
{
    public class CalleConfiguration : IEntityTypeConfiguration<Calle>
    {
        public void Configure(EntityTypeBuilder<Calle> builder)
        {
            builder.ToTable("Calles");
            builder.HasKey("Id");
            builder.Property(a => a.Nombre).HasColumnName("Nombre").HasMaxLength(100).IsRequired().IsUnicode(false);
            builder.Property(a => a.Codigo).HasColumnName("Codigo").HasMaxLength(10).IsRequired().IsUnicode(false);
            builder.Property(a => a.CodigoPostal).HasColumnName("CP").HasMaxLength(10).IsRequired().IsUnicode(false);
            builder.Property(a => a.NumeroParInicial).HasColumnName("NumeroParIni").HasMaxLength(10).IsUnicode(false);
            builder.Property(a => a.NumeroParFinal).HasColumnName("NumeroParFin").HasMaxLength(10).IsUnicode(false);
            builder.Property(a => a.NumeroImparInicial).HasColumnName("NumeroImparIni").HasMaxLength(10).IsUnicode(false);
            builder.Property(a => a.NumeroImparFinal).HasColumnName("NumeroImparFin").HasMaxLength(10).IsUnicode(false);
            builder.Property(a => a.CodigoINE).HasColumnName("CodINE").HasMaxLength(50).IsUnicode(false);
            builder.Property(a => a.CodigoGIS).HasColumnName("CodGIS").HasMaxLength(50).IsUnicode(false);
            builder.Property(a => a.TipoVia).HasColumnName("TipoVia").HasMaxLength(2).IsUnicode(false);
            builder.Property(a => a.CategoriaVia).HasColumnName("CategoriaVia").HasMaxLength(25).IsUnicode(false);
        }
    }
}
