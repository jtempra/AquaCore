using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaCore.Core.Entities
{
    public class Anotacion
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Nota { get; set; }
        public Empleado Empleado { get; set; }
    }
}
