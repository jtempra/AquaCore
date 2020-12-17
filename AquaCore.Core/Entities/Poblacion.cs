using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaCore.Core.Entities
{
    public class Poblacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public string Observaciones { get; set; }
        public string CodigoACA { get; set; }
        public string CodigoINE { get; set; }
        public IEnumerable<Zona> Zonas { get; set; }
    }
}
