using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApi1.Models;

namespace WebApi1.Models
{
    public class TeDhenatPerdoruesit
    {
        [Key]
        public int TeDhenatId { get; set; }
        public int UserId { get; set; }

        public string? NrKontaktit { get; set; }

        public string? Qyteti { get; set; }

        public int? ZipKodi { get; set; }

        public string? Adresa { get; set; }
        public string? Shteti { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual Perdoruesi? User { get; set; }
    }
}
