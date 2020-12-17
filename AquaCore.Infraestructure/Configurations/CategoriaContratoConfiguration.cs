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
    class CategoriaContratoConfiguration : IEntityTypeConfiguration<CategoriaContrato>
    {
        public void Configure(EntityTypeBuilder<CategoriaContrato> builder)
        {
            builder.ToTable("CategoriasContrato");
            builder.HasKey("Id");
            builder.Property(a => a.Categoria).HasColumnName("Categoria").HasMaxLength(100).IsRequired().IsUnicode(false);
            builder.Property(a => a.Observaciones).HasColumnName("Observaciones").HasMaxLength(500).IsUnicode(false);
        }
    }
}
