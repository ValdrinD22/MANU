using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApi1.Models;

namespace WebApi1.Models
{
    public class TeDhenatRegjistrimit
    {
        [Key]
        public int Id { get; set; }

        public int? IdRegjistrimit { get; set; }

        public int? IdProduktit { get; set; }

        public int? SasiaStokut { get; set; }

        public decimal? QmimiBleres { get; set; }

        public decimal? QmimiShites { get; set; }
        [ForeignKey(nameof(IdProduktit))]
        public virtual Produkti? Produkti { get; set; }
        [ForeignKey(nameof(IdRegjistrimit))]
        public virtual RegjistrimiStokut? Regjistrimi { get; set; }
    }
}
