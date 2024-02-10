using System;
using System.Collections.Generic;

namespace Api_padron.Models
{
    public partial class Ocupacion
    {
        public short Id { get; set; }
        public string? Descripcion { get; set; }
        public string? RequiereTitulo { get; set; }
        public string? Estatus { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? IdUsuarioCreacion { get; set; }
        public Guid? RegId { get; set; }
        public string? Militar { get; set; }
    }
}
