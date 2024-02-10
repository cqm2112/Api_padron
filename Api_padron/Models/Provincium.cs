using System;
using System.Collections.Generic;

namespace Api_padron.Models
{
    public partial class Provincium
    {
        public short Id { get; set; }
        public string? Descripcion { get; set; }
        public short? IdmunicipioCabecera { get; set; }
        public string? Oficio { get; set; }
        public string? Estatus { get; set; }
        public string? Zona { get; set; }
        public Guid? RegId { get; set; }
        public int? Region { get; set; }
    }
}
