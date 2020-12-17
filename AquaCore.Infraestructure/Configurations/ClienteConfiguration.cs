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
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey("Id");
            builder.Property(a => a.TipoCliente).HasColumnName("TipoCliente").HasMaxLength(100).IsRequired().IsUnicode(false);
            builder.Property(a => a.SituacionCliente).HasColumnName("SituacionCliente").HasMaxLength(10).IsRequired().IsUnicode(false);
            builder.Property(a => a.FechaAlta).HasColumnName("FechaAlta").HasMaxLength(10).IsRequired().IsUnicode(false);
            builder.Property(a => a.FechaBaja).HasColumnName("FechaBaja").HasMaxLength(10).IsUnicode(false);
            builder.Property(a => a.CodigoContable).HasColumnName("CodigoContable").HasMaxLength(10).IsUnicode(false);
            builder.Property(a => a.Observaciones).HasColumnName("Observaciones").HasMaxLength(10).IsUnicode(false);
            builder.Property(a => a.Nombre).HasColumnName("Nombre").HasMaxLength(10).IsUnicode(false);
            builder.Property(a => a.Apellido1).HasColumnName("Apellido1").HasMaxLength(50).IsUnicode(false);
            builder.Property(a => a.Apellido2).HasColumnName("Apellido2").HasMaxLength(50).IsUnicode(false);
            builder.Property(a => a.NIF).HasColumnName("NIF").HasMaxLength(2).IsUnicode(false);
            builder.Property(a => a.TipoIdentificacion).HasColumnName("TipoIdentificacion").HasMaxLength(25).IsUnicode(false);
            builder.Property(a => a.Direccion).HasColumnName("Direccion").HasMaxLength(100).IsRequired().IsUnicode(false);
            builder.Property(a => a.Direccion2).HasColumnName("Direccion2").HasMaxLength(10).IsRequired().IsUnicode(false);
            builder.Property(a => a.Poblacion).HasColumnName("Poblacion").HasMaxLength(10).IsRequired().IsUnicode(false);
            builder.Property(a => a.Provincia).HasColumnName("Provincia").HasMaxLength(10).IsUnicode(false);
            builder.Property(a => a.Pais).HasColumnName("Pais").HasMaxLength(10).IsUnicode(false);
            builder.Property(a => a.Telefono1).HasColumnName("Telefono1").HasMaxLength(10).IsUnicode(false);
            builder.Property(a => a.Telefono2).HasColumnName("Telefono2").HasMaxLength(10).IsUnicode(false);
            builder.Property(a => a.Telefono3).HasColumnName("Telefono3").HasMaxLength(50).IsUnicode(false);
            builder.Property(a => a.Movil1).HasColumnName("Movil1").HasMaxLength(50).IsUnicode(false);
            builder.Property(a => a.Movil2).HasColumnName("Movil2").HasMaxLength(2).IsUnicode(false);
            builder.Property(a => a.Movil3).HasColumnName("Movil3").HasMaxLength(25).IsUnicode(false);
            builder.Property(a => a.Email1).HasColumnName("Email1").HasMaxLength(50).IsUnicode(false);
            builder.Property(a => a.Email2).HasColumnName("Email2").HasMaxLength(2).IsUnicode(false);
            builder.Property(a => a.Email3).HasColumnName("Email3").HasMaxLength(25).IsUnicode(false);
            builder.Property(a => a.IBAN).HasColumnName("IBAN").HasMaxLength(2).IsUnicode(false);
            builder.Property(a => a.BIC).HasColumnName("BIC").HasMaxLength(25).IsUnicode(false);
        }
    }
}
