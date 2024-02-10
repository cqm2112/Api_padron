using System;
using System.Collections.Generic;

namespace Api_padron.Models
{
    public partial class RecintoResumenSenalGp
    {
        public int IdRecinto { get; set; }
        public string? CodigoRecinto { get; set; }
        public string? DescripcionRecinto { get; set; }
        public string? DireccionRecinto { get; set; }
        public string? EstatusRecinto { get; set; }
        public short? IdCircunscripcion { get; set; }
        public string? DescripcionCircunscripcion { get; set; }
        public short? IdProvincia { get; set; }
        public string? DescripcionProvincia { get; set; }
        public string? Zona { get; set; }
        public short? IdMunicipio { get; set; }
        public string? DescripcionMunicipio { get; set; }
        public short? IdDistritoMunicipal { get; set; }
        public string? DescripcionDistritoMunicipal { get; set; }
        public short? IdCiudadSeccion { get; set; }
        public string? CodigoCiudad { get; set; }
        public string? DescripcionCiudad { get; set; }
        public int? IdSectorParaje { get; set; }
        public string? CodigoSector { get; set; }
        public string? DescripcionSector { get; set; }
        public string? EstatusSector { get; set; }
        public string? Codigocircunscripcion { get; set; }
        public string? Propiedad { get; set; }
        public string? Electricidad { get; set; }
        public string? Ubicación { get; set; }
        public string? PosicionamientoGlobal { get; set; }
        public string? ConectivaCj { get; set; }
        public string? Comunicacion2020 { get; set; }
        public string? Portadoras { get; set; }
    }
}
