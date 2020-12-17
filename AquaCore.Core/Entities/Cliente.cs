using AquaCore.Core.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaCore.Core.Entities
{
    public class Cliente : DatosContacto 
    {
        public int Id { get; set; }
        public TipoCliente  TipoCliente { get; set; }
        public SituacionCliente SituacionCliente  { get; set; }
        public DateTime  FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string CodigoContable { get; set; }
        public string Observaciones { get; set; }
        public IEnumerable<Anotacion> Anotaciones { get; set; }
        public IEnumerable<Contrato>  Contratos { get; set; }
    }
}
