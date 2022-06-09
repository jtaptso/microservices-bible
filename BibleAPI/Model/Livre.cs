using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibleAPI.Model
{
    [Table("Livre")]
    public class Livre : Common
    {
        [Key]
        public int LivreId { get; set; }
        [Required, Column("Numero", Order = 1)]
        public string? Nom { get; set; }
        public List<Chapitre> Chapitres { get; set; }
        public string? Comment { get; set; }
        [ForeignKey("Testament")]
        public int TestamentId { get; set; }
        public Testament Testament { get; set; }
    }
}
