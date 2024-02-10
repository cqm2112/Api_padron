using System;
using System.Collections.Generic;

namespace Api_padron.Models
{
    public partial class MacroRegion
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public Guid? RegId { get; set; }
    }
}
