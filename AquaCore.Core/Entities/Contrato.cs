using AquaCore.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaCore.Core.Entities
{
    public class Contrato
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public IEnumerable<Contacto> Contactos { get; set; }
        public Ubicacion  Ubicacion { get; set; }
        public RutaLectura  RutaLectuta { get; set; }
        public string OrdenRutaLectura  { get; set; }
        public TipoResidencia TipoResidencia { get; set; }
        public SituacionContrato SituacionContrato { get; set; }
        public DateTime FechaSolicitudAlta { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaAltaFacturacion { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public DateTime? FechaFinObra { get; set; }
        public DateTime? FechaBaja { get; set; }
        public TipoBaja TipoBaja { get; set; }
        public Double  Fianza { get; set; }
        public SituacionFianza SituacionFianza { get; set; }
        public DateTime?  FechaEntregaFianza { get; set; }
        public DateTime? FechaDevolucionFianza { get; set; }
        public PeriodoFacturacion PeriodoFacturacion { get; set; }
        public Boolean Facturable { get; set; }
        public Boolean NoFacturableImpago { get; set; }
        public Boolean Cortable { get; set; }
        public Boolean SuministroCortado { get; set; }
        public Boolean SuministroRestringido { get; set; }
        public Boolean  GranConsumidor { get; set; }
        public Boolean  Empleado { get; set; }
        public Double ConsumoACompensar { get; set; }
        public Idioma Idioma { get; set; }
        public FamiliaContrato Familia { get; set; }
        public CategoriaContrato Categoria { get; set; }
        public UsoContrato Uso { get; set; }
        public TipoSuministro TipoSuministro { get; set; }
        public int NumPersonasCensadas { get; set; }
        public Boolean EnviarFacturasEmail { get; set; }
        public Boolean EnviarFacturasCorreo { get; set; }
        public Boolean EnviarCorrespondencia { get; set; }
        public Boolean CobrarGastosCorrespondencia { get; set; }
        public int NumeroLocales { get; set; }
        public int NumeroViviendas { get; set; }
        public int NumeroOtros { get; set; }
        public ZonaFacturacion ZonaFacturacion { get; set; }
        public string Mandato { get; set; }
        public DateTime FechaMandato { get; set; }
        public string CodigoContable { get; set; }
        public TipoCliente TipoCliente { get; set; }
        public Boolean AccesoOV { get; set; }
        public PerfilOV PerfilOV { get; set; }
        public Boolean AmpliacionTramos { get; set; }
        public DateTime? FechaInicioAmpliacionTramos { get; set; }
        public DateTime? FechaFinAmpliacionTramos { get; set; }
        public Boolean CanonSocial { get; set; }
        public DateTime? FechaInicioCanonSocial { get; set; }
        public DateTime? FechaFinCanonSocial { get; set; }
        public Boolean PobrezaEnergetica { get; set; }
        public DateTime? FechaInicioPobrezaEnergetica { get; set; }
        public DateTime? FechaFinPobrezaEnergetica { get; set; }
        public TipoControlConsumo TipoControlConsumo { get; set; }
        public double MinConsumo { get; set; }
        public double MaxConsumo { get; set; }
        public IEnumerable<DocumentoContrato> Documentos { get; set; }
    }
}
