using AquaCore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaCore.Infraestructure.Contexts
{
    public class AquaCoreDbContext : DbContext
    {
        public AquaCoreDbContext(DbContextOptions<AquaCoreDbContext> options): base(options)
        {

        }

        public virtual DbSet<Anotacion> Anotaciones { get; set; }
        public virtual DbSet<Calle> Calles { get; set; }
        public virtual DbSet<CategoriaContrato> CategoriasContrato { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Contacto> Contactos { get; set; }
        public virtual DbSet<Contador> Contadores { get; set; }
        public virtual DbSet<Contrato> Contratos { get; set; }
        public virtual DbSet<DocumentoContrato> DocumentosContrato { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<FamiliaContrato> FamiliasContrato { get; set; }
        public virtual DbSet<MarcaContador> MarcasContador { get; set; }
        public virtual DbSet<Poblacion> Poblaciones { get; set; }
        public virtual DbSet<RutaLectura> RutasLectura { get; set; }
        public virtual DbSet<Servicio> Servicios { get; set; }
        public virtual DbSet<TarifaServicio> TarifasServicio { get; set; }
        public virtual DbSet<TipoServicio> TiposServicio { get; set; }
        public virtual DbSet<Ubicacion> Ubicaciones { get; set; }
        public virtual DbSet<UsoContrato> UsosContrato { get; set; }
        public virtual DbSet<Zona> Zonas { get; set; }
        public virtual DbSet<ZonaFacturacion> ZonasFacturacion { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //}
    }
}
