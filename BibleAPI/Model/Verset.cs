using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibleAPI.Model
{
    [Table("Verset")]
    public class Verset : Common
    {
        [Key]
        public int VersetId { get; set; }
        [Required, Column("Number", Order = 1)]
        public int Numero { get; set; }
        public List<VersetVersion> Versions { get; set; }
        public string? correspondances { get; set; }

        [ForeignKey("Chapitre")]
        public int ChapitreId { get; set; }
        public Chapitre Chapitre { get; set; }
    }
}
