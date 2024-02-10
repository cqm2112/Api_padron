using System;
using System.Collections.Generic;

namespace Api_padron.Models
{
    public partial class Transhumancia2024AntesAplicar
    {
        public string Cedula { get; set; } = null!;
        public string? UltimaSolicitud { get; set; }
        public int? IdsectorParaje { get; set; }
        public int? Idcolegio { get; set; }
        public string? DescripcionProvincia { get; set; }
        public string? DescripcionMunicipio { get; set; }
        public string? DescripcionDistritoMunicipal { get; set; }
        public string? DescripcionCiudad { get; set; }
        public string? DescripcionSector { get; set; }
    }
}
