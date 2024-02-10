using System;
using System.Collections.Generic;

namespace Api_padron.Models
{
    public partial class Fusione
    {
        public int IdMunicipio { get; set; }
        public string CodigoRecinto { get; set; } = null!;
        public string ColegioOrigen { get; set; } = null!;
        public string? CodigoRecintoDestino { get; set; }
        public string? ColegioDestino { get; set; }
        public int? InscritosOrigen { get; set; }
    }
}
