using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaCore.Core.Entities
{
    public class TarifaServicio
    {
        public int Id { get; set; }
        public Servicio Servicio { get; set; }
        public TipoServicio TipoServicio { get; set; }
        public int Factor { get; set; }
        public string Observaciones { get; set; }
    }
}
