using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaCore.Core.Entities
{
    public class FamiliaContrato
    {
        public int Id { get; set; }
        public string Familia { get; set; }
        public string Observaciones { get; set; }
        public IEnumerable<Contrato> Contratos { get; set; }
    }
}
