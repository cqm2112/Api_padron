using System;
using System.Collections.Generic;

namespace Api_padron.Models
{
    public partial class RecintosCoordenadasSenal
    {
        public double? IdRecinto { get; set; }
        public double? IdMunicipio { get; set; }
        public string? CodigoRecinto { get; set; }
        public string? Propiedad { get; set; }
        public string? Electricidad { get; set; }
        public string? Ubicación { get; set; }
        public string? PosicionamientoGlobal { get; set; }
        public string? Conectividad { get; set; }
        public string? Comunicacion2020 { get; set; }
        public string? RecintoMunicipio { get; set; }
        public double? Primaria { get; set; }
    }
}
