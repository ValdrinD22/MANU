
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi1.Models
{
    public class Sculptor212261697
    {

        [Key]

        public int SculptorId {  get; set; }

        public string? Emri {  get; set; }

        public int DataLindjes { get; set; }

        public string IsDeleted { get; set; }

        [ForeignKey(nameof(Sculpture212261697))]

        public virtual List<Sculpture212261697> Sculpture2122 { get; set; }

            
    }
}
