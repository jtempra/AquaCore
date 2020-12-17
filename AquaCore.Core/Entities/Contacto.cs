using AquaCore.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaCore.Core.Entities
{
    public class Contacto : DatosContacto 
    {
        public int Id { get; set; }
        public TipoContacto TipoContacto { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime?  FechaBaja { get; set; }
        public string Observaciones { get; set; }
        public IEnumerable<Anotacion> Anotaciones { get; set; }
    }
}
