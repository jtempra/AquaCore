using AquaCore.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaCore.Core.Entities
{
    public abstract class DatosContacto
    {
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string NombreCompleto() => Nombre + " " + Apellido1 + " " + Apellido2;
        public string NIF { get; set; }
        public TipoIdentificacion TipoIdentificacion { get; set; }
        public string Direccion { get; set; }
        public string Direccion2 { get; set; }
        public string CodigoPostal { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Telefono3 { get; set; }
        public string Movil1 { get; set; }
        public string Movil2 { get; set; }
        public string Movil3 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string IBAN { get; set; }
        public string BIC { get; set; }
    }
}
