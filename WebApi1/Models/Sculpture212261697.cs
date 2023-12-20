using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApi1.Models
{
    public class Sculpture212261697
    {
        [Key]

        public int SculptureId { get; set; }

        public string? Title { get; set; }

        public string? Material { get; set; }

        public String ? IsDeleted { get; set; }

        [ForeignKey(nameof(SculptureId))]

        public virtual List<Sculptor212261697>? Sculptor212261697 { get; set; }
    }
}
