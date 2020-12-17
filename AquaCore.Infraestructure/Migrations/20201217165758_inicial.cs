using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AquaCore.Infraestructure.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriasContrato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasContrato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoCliente = table.Column<int>(type: "int", nullable: false),
                    SituacionCliente = table.Column<int>(type: "int", nullable: false),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CodigoContable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoIdentificacion = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poblacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Movil1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Movil2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Movil3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IBAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BIC = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoEmpleado = table.Column<int>(type: "int", nullable: false),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoIdentificacion = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poblacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Movil1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Movil2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Movil3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IBAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BIC = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FamiliasContrato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Familia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamiliasContrato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarcasContador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcasContador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Poblaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoACA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoINE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poblaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RutasLectura",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RutasLectura", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsosContrato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsosContrato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ZonasFacturacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZonasFacturacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zonas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PoblacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zonas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zonas_Poblaciones_PoblacionId",
                        column: x => x.PoblacionId,
                        principalTable: "Poblaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TiposServicio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposServicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TiposServicio_Servicios_ServicioId",
                        column: x => x.ServicioId,
                        principalTable: "Servicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Calles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroParInicial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroParFinal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroImparInicial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroaImparFinal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoINE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoGIS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoVia = table.Column<int>(type: "int", nullable: false),
                    CategoriaVia = table.Column<int>(type: "int", nullable: false),
                    ZonaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calles_Zonas_ZonaId",
                        column: x => x.ZonaId,
                        principalTable: "Zonas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TarifasServicio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicioId = table.Column<int>(type: "int", nullable: true),
                    TipoServicioId = table.Column<int>(type: "int", nullable: true),
                    Factor = table.Column<int>(type: "int", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TarifasServicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TarifasServicio_Servicios_ServicioId",
                        column: x => x.ServicioId,
                        principalTable: "Servicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TarifasServicio_TiposServicio_TipoServicioId",
                        column: x => x.TipoServicioId,
                        principalTable: "TiposServicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ubicaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PoblacionId = table.Column<int>(type: "int", nullable: true),
                    ZonaId = table.Column<int>(type: "int", nullable: true),
                    CalleId = table.Column<int>(type: "int", nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bloque = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parcela = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Local = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Escalera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Piso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Puerta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PosX = table.Column<int>(type: "int", nullable: false),
                    PosY = table.Column<int>(type: "int", nullable: false),
                    Latitud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Localizacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UbicacionPadreId = table.Column<int>(type: "int", nullable: true),
                    TipoImputacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ubicaciones_Calles_CalleId",
                        column: x => x.CalleId,
                        principalTable: "Calles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ubicaciones_Poblaciones_PoblacionId",
                        column: x => x.PoblacionId,
                        principalTable: "Poblaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ubicaciones_Ubicaciones_UbicacionPadreId",
                        column: x => x.UbicacionPadreId,
                        principalTable: "Ubicaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ubicaciones_Zonas_ZonaId",
                        column: x => x.ZonaId,
                        principalTable: "Zonas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropiedadContador = table.Column<int>(type: "int", nullable: false),
                    MarcaContadorId = table.Column<int>(type: "int", nullable: true),
                    Calibre = table.Column<int>(type: "int", nullable: false),
                    TipoContador = table.Column<int>(type: "int", nullable: false),
                    ClaseContador = table.Column<int>(type: "int", nullable: false),
                    PeriodoRevision = table.Column<int>(type: "int", nullable: false),
                    Digitos = table.Column<int>(type: "int", nullable: false),
                    FechaInstalacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpleadoInstalacionId = table.Column<int>(type: "int", nullable: true),
                    FechaRevision = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmpleadoRevisionId = table.Column<int>(type: "int", nullable: true),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmpleadoBajaId = table.Column<int>(type: "int", nullable: true),
                    UbicacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contadores_Empleados_EmpleadoBajaId",
                        column: x => x.EmpleadoBajaId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contadores_Empleados_EmpleadoInstalacionId",
                        column: x => x.EmpleadoInstalacionId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contadores_Empleados_EmpleadoRevisionId",
                        column: x => x.EmpleadoRevisionId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contadores_MarcasContador_MarcaContadorId",
                        column: x => x.MarcaContadorId,
                        principalTable: "MarcasContador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contadores_Ubicaciones_UbicacionId",
                        column: x => x.UbicacionId,
                        principalTable: "Ubicaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contratos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: true),
                    UbicacionId = table.Column<int>(type: "int", nullable: true),
                    RutaLectutaid = table.Column<int>(type: "int", nullable: true),
                    OrdenRutaLectura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoResidencia = table.Column<int>(type: "int", nullable: false),
                    SituacionContrato = table.Column<int>(type: "int", nullable: false),
                    FechaSolicitudAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaAltaFacturacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaFinObra = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TipoBaja = table.Column<int>(type: "int", nullable: false),
                    Fianza = table.Column<double>(type: "float", nullable: false),
                    SituacionFianza = table.Column<int>(type: "int", nullable: false),
                    FechaEntregaFianza = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaDevolucionFianza = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PeriodoFacturacion = table.Column<int>(type: "int", nullable: false),
                    Facturable = table.Column<bool>(type: "bit", nullable: false),
                    NoFacturableImpago = table.Column<bool>(type: "bit", nullable: false),
                    Cortable = table.Column<bool>(type: "bit", nullable: false),
                    SuministroCortado = table.Column<bool>(type: "bit", nullable: false),
                    SuministroRestringido = table.Column<bool>(type: "bit", nullable: false),
                    GranConsumidor = table.Column<bool>(type: "bit", nullable: false),
                    Empleado = table.Column<bool>(type: "bit", nullable: false),
                    ConsumoACompensar = table.Column<double>(type: "float", nullable: false),
                    Idioma = table.Column<int>(type: "int", nullable: false),
                    FamiliaId = table.Column<int>(type: "int", nullable: true),
                    CategoriaId = table.Column<int>(type: "int", nullable: true),
                    UsoId = table.Column<int>(type: "int", nullable: true),
                    TipoSuministro = table.Column<int>(type: "int", nullable: false),
                    NumPersonasCensadas = table.Column<int>(type: "int", nullable: false),
                    EnviarFacturasEmail = table.Column<bool>(type: "bit", nullable: false),
                    EnviarFacturasCorreo = table.Column<bool>(type: "bit", nullable: false),
                    EnviarCorrespondencia = table.Column<bool>(type: "bit", nullable: false),
                    CobrarGastosCorrespondencia = table.Column<bool>(type: "bit", nullable: false),
                    NumeroLocales = table.Column<int>(type: "int", nullable: false),
                    NumeroViviendas = table.Column<int>(type: "int", nullable: false),
                    NumeroOtros = table.Column<int>(type: "int", nullable: false),
                    ZonaFacturacionId = table.Column<int>(type: "int", nullable: true),
                    Mandato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaMandato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodigoContable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoCliente = table.Column<int>(type: "int", nullable: false),
                    AccesoOV = table.Column<bool>(type: "bit", nullable: false),
                    PerfilOV = table.Column<int>(type: "int", nullable: false),
                    AmpliacionTramos = table.Column<bool>(type: "bit", nullable: false),
                    FechaInicioAmpliacionTramos = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaFinAmpliacionTramos = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CanonSocial = table.Column<bool>(type: "bit", nullable: false),
                    FechaInicioCanonSocial = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaFinCanonSocial = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PobrezaEnergetica = table.Column<bool>(type: "bit", nullable: false),
                    FechaInicioPobrezaEnergetica = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaFinPobrezaEnergetica = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TipoControlConsumo = table.Column<int>(type: "int", nullable: false),
                    MinConsumo = table.Column<double>(type: "float", nullable: false),
                    MaxConsumo = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contratos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contratos_CategoriasContrato_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "CategoriasContrato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contratos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contratos_FamiliasContrato_FamiliaId",
                        column: x => x.FamiliaId,
                        principalTable: "FamiliasContrato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contratos_RutasLectura_RutaLectutaid",
                        column: x => x.RutaLectutaid,
                        principalTable: "RutasLectura",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contratos_Ubicaciones_UbicacionId",
                        column: x => x.UbicacionId,
                        principalTable: "Ubicaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contratos_UsosContrato_UsoId",
                        column: x => x.UsoId,
                        principalTable: "UsosContrato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contratos_ZonasFacturacion_ZonaFacturacionId",
                        column: x => x.ZonaFacturacionId,
                        principalTable: "ZonasFacturacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contactos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoContacto = table.Column<int>(type: "int", nullable: false),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContratoId = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoIdentificacion = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poblacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Movil1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Movil2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Movil3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IBAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BIC = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contactos_Contratos_ContratoId",
                        column: x => x.ContratoId,
                        principalTable: "Contratos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DocumentosContrato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Obligatorio = table.Column<bool>(type: "bit", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ruta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContratoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentosContrato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentosContrato_Contratos_ContratoId",
                        column: x => x.ContratoId,
                        principalTable: "Contratos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Anotaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpleadoId = table.Column<int>(type: "int", nullable: true),
                    ClienteId = table.Column<int>(type: "int", nullable: true),
                    ContactoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anotaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Anotaciones_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Anotaciones_Contactos_ContactoId",
                        column: x => x.ContactoId,
                        principalTable: "Contactos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Anotaciones_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anotaciones_ClienteId",
                table: "Anotaciones",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Anotaciones_ContactoId",
                table: "Anotaciones",
                column: "ContactoId");

            migrationBuilder.CreateIndex(
                name: "IX_Anotaciones_EmpleadoId",
                table: "Anotaciones",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Calles_ZonaId",
                table: "Calles",
                column: "ZonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Contactos_ContratoId",
                table: "Contactos",
                column: "ContratoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contadores_EmpleadoBajaId",
                table: "Contadores",
                column: "EmpleadoBajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Contadores_EmpleadoInstalacionId",
                table: "Contadores",
                column: "EmpleadoInstalacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Contadores_EmpleadoRevisionId",
                table: "Contadores",
                column: "EmpleadoRevisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Contadores_MarcaContadorId",
                table: "Contadores",
                column: "MarcaContadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Contadores_UbicacionId",
                table: "Contadores",
                column: "UbicacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_CategoriaId",
                table: "Contratos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_ClienteId",
                table: "Contratos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_FamiliaId",
                table: "Contratos",
                column: "FamiliaId");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_RutaLectutaid",
                table: "Contratos",
                column: "RutaLectutaid");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_UbicacionId",
                table: "Contratos",
                column: "UbicacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_UsoId",
                table: "Contratos",
                column: "UsoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_ZonaFacturacionId",
                table: "Contratos",
                column: "ZonaFacturacionId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosContrato_ContratoId",
                table: "DocumentosContrato",
                column: "ContratoId");

            migrationBuilder.CreateIndex(
                name: "IX_TarifasServicio_ServicioId",
                table: "TarifasServicio",
                column: "ServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_TarifasServicio_TipoServicioId",
                table: "TarifasServicio",
                column: "TipoServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposServicio_ServicioId",
                table: "TiposServicio",
                column: "ServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_Ubicaciones_CalleId",
                table: "Ubicaciones",
                column: "CalleId");

            migrationBuilder.CreateIndex(
                name: "IX_Ubicaciones_PoblacionId",
                table: "Ubicaciones",
                column: "PoblacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Ubicaciones_UbicacionPadreId",
                table: "Ubicaciones",
                column: "UbicacionPadreId");

            migrationBuilder.CreateIndex(
                name: "IX_Ubicaciones_ZonaId",
                table: "Ubicaciones",
                column: "ZonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Zonas_PoblacionId",
                table: "Zonas",
                column: "PoblacionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anotaciones");

            migrationBuilder.DropTable(
                name: "Contadores");

            migrationBuilder.DropTable(
                name: "DocumentosContrato");

            migrationBuilder.DropTable(
                name: "TarifasServicio");

            migrationBuilder.DropTable(
                name: "Contactos");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "MarcasContador");

            migrationBuilder.DropTable(
                name: "TiposServicio");

            migrationBuilder.DropTable(
                name: "Contratos");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropTable(
                name: "CategoriasContrato");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "FamiliasContrato");

            migrationBuilder.DropTable(
                name: "RutasLectura");

            migrationBuilder.DropTable(
                name: "Ubicaciones");

            migrationBuilder.DropTable(
                name: "UsosContrato");

            migrationBuilder.DropTable(
                name: "ZonasFacturacion");

            migrationBuilder.DropTable(
                name: "Calles");

            migrationBuilder.DropTable(
                name: "Zonas");

            migrationBuilder.DropTable(
                name: "Poblaciones");
        }
    }
}
