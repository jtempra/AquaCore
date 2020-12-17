using AquaCore.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaCore.Core.Entities
{
    public class Ubicacion
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public Poblacion Poblacion { get; set; }
        public Zona Zona { get; set; }
        public Calle Calle { get; set; }
        public string Numero { get; set; }
        public string Bloque { get; set; }
        public string Parcela { get; set; }
        public string Local { get; set; }
        public string Escalera { get; set; }
        public string Piso { get; set; }
        public string Puerta { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Localizacion { get; set; }
        public string Observaciones { get; set; }
        public IEnumerable<Contrato> Contratos { get; set; }
        public IEnumerable<Contador>  Contadores { get; set; }
        public Ubicacion UbicacionPadre { get; set; }
        public IEnumerable<Ubicacion> UbicacionesHijas { get; set; }
        public TipoImputacionContadorPadre TipoImputacion { get; set; }
    }
}
