using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;


namespace WebApi1.Models
{
    public partial class Kompania
    {
        [Key]
        public int KompaniaId { get; set; }

        public string? EmriKompanis { get; set; }

        public string? Logo { get; set; }

        public string? Adresa { get; set; }
        public virtual List<Produkti>? Produkti { get; set; }
    }
}
