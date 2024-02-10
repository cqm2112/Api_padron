using System;
using System.Collections.Generic;

namespace Api_padron.Models
{
    public partial class Colegio2024
    {
        public short? IdMunicipio { get; set; }
        public string? CodigoRecinto { get; set; }
        public string CodigoColegio { get; set; } = null!;
        public int IdColegio { get; set; }
        public string DescripcionColegio { get; set; } = null!;
        public int Habiles { get; set; }
        public int Inhabilitados { get; set; }
        public string? HashColegio { get; set; }
    }
}
