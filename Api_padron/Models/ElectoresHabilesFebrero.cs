using System;
using System.Collections.Generic;

namespace Api_padron.Models
{
    public partial class ElectoresHabilesFebrero
    {
        public int? IdProvincia { get; set; }
        public int? IdMunicipio { get; set; }
        public string? CodigoCircunscripcion { get; set; }
        public string? CodigoRecinto { get; set; }
        public string? CodigoColegio { get; set; }
        public string Cedula { get; set; } = null!;
        public string? Nombres { get; set; }
        public string? Apellido1 { get; set; }
        public string? Apellido2 { get; set; }
        public string? NombresPlastico { get; set; }
        public string? ApellidosPlastico { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? IdNacionalidad { get; set; }
        public string? IdSexo { get; set; }
        public string? IdEstadoCivil { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdCausaCancelacion { get; set; }
        public int? IdColegio { get; set; }
        public int? IdColegioOrigen { get; set; }
        public int? IdMunicipioOrigen { get; set; }
        public string? ColegioOrigen { get; set; }
        public int PosPagina { get; set; }
        public string? DescripcionColegio { get; set; }
        public int? IdRecinto { get; set; }
        public string? DescripcionRecinto { get; set; }
        public string? DireccionRecinto { get; set; }
        public string? EstatusRecinto { get; set; }
        public string? DescripcionProvincia { get; set; }
        public string? Zona { get; set; }
        public string? DescripcionMunicipio { get; set; }
        public short? IdDistritoMunicipal { get; set; }
        public string? DescripcionDistritoMunicipal { get; set; }
        public short? IdCiudadSeccion { get; set; }
        public string? CodigoCiudad { get; set; }
        public string? DescripcionCiudad { get; set; }
        public string? CodigoSector { get; set; }
        public string? DescripcionSector { get; set; }
        public string? EstatusSector { get; set; }
    }
}
