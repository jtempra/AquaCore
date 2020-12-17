using AquaCore.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaCore.Core.Entities
{
    public class Contador
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public PropiedadContador PropiedadContador { get; set; }
        public MarcaContador MarcaContador { get; set; }
        public CalibreContador Calibre { get; set; }
        public TipoContador TipoContador { get; set; }
        public ClaseContador ClaseContador { get; set; }
        public int PeriodoRevision { get; set; }
        public int Digitos { get; set; }
        public DateTime FechaInstalacion { get; set; }
        public Empleado EmpleadoInstalacion { get; set; }
        public DateTime? FechaRevision { get; set; }
        public Empleado EmpleadoRevision { get; set; }
        public DateTime? FechaBaja { get; set; }
        public Empleado EmpleadoBaja { get; set; }
    }
}
