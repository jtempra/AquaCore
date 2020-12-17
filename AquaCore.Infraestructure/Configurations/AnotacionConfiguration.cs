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
            builder.Property (a=>a.)
        }
    }
}
