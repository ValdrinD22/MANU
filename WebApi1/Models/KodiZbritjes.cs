﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi1.Models
{
    public partial class KodiZbritjes
    {
        [Key]
        public string Kodi { get; set; } = null!;

        public DateTime? DataKrijimit { get; set; }

        public decimal? QmimiZbritjes { get; set; }

        public int? IdProdukti { get; set; }

        [ForeignKey("IdProdukti")]
        public virtual Produkti? Produkti { get; set; }

    }
}
