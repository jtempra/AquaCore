using AquaCore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaCore.Infraestructure
{
    public class AnotacionConfiguration : IEntityTypeConfiguration<Anotacion>
    {
        public void Configure(EntityTypeBuilder<Anotacion> builder)
        {
            builder.ToTable("Anotaciones");
            builder.HasKey("Id");
            builder.Property(a => a.Fecha).HasColumnName("Fecha").HasColumnType("DateTime").IsRequired();
            builder.Property(a => a.Nota).HasColumnName("Nota").HasMaxLength(500).IsRequired().IsUnicode(false);
        }
    }
}
