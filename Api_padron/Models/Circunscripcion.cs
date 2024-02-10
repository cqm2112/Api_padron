using System;
using System.Collections.Generic;

namespace Api_padron.Models
{
    public partial class Circunscripcion
    {
        public short Id { get; set; }
        public short Idprovincia { get; set; }
        public string? CodigoCircunscripcion { get; set; }
        public string? Descripcion { get; set; }
        public Guid? RegId { get; set; }
    }
}
