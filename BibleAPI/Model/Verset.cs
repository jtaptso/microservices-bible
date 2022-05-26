using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibleAPI.Model
{
    [Table("Verset")]
    public class Verset : Common
    {
        [Key, Column(Order = 0)]
        public int VersetId { get; set; }
        [Required, Column("Number", Order = 1)]
        public int Numero { get; set; }
        [Required, Column(Order = 2)]
        public string Text { get; set; }
        [Column(Order = 3)]
        public string? correspondances { get; set; }
        public string? Titre { get; set; }

        [ForeignKey("Chapitre")]
        public int ChapitreId { get; set; }
        public Chapitre Chapitre { get; set; }
    }
}
