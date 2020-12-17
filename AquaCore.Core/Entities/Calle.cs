using AquaCore.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaCore.Core.Entities
{
    public class Calle
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string CodigoPostal { get; set; }
        public string NumeroParInicial { get; set; }
        public string NumeroParFinal { get; set; }
        public string NumeroImparInicial { get; set; }
        public string NumeroImparFinal { get; set; }
        public string CodigoINE { get; set; }
        public string CodigoGIS { get; set; }
        public TipoVia TipoVia { get; set; }
        public CategoriaVia CategoriaVia { get; set; }
        public Zona Zona { get; set; }


    }
}
