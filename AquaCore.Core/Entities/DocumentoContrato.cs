using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaCore.Core.Entities
{
    public class DocumentoContrato
    {
        public int Id { get; set; }
        public string Documento { get; set; }
        public string Descripcion { get; set; }
        public DateTime  FechaEntrega { get; set; }
        public Boolean Obligatorio { get; set; }
        public string Observaciones { get; set; }
        public string Ruta { get; set; }
        public Contrato Contrato { get; set; }
    }
}
