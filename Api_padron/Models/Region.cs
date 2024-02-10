using System;
using System.Collections.Generic;

namespace Api_padron.Models
{
    public partial class Region
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public int? IdmacroRegion { get; set; }
    }
}
