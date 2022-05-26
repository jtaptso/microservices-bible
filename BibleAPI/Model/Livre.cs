using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibleAPI.Model
{
    [Table("Livre")]
    public class Livre : Common
    {
        [Key, Column(Order = 0)]
        public int LivreId { get; set; }
        [Required, Column("Numero", Order = 1)]
        public string? Nom { get; set; }
        public List<Chapitre> Chapitres { get; set; }
        public Testament Testament { get; set; }
        [ForeignKey("Bible")]
        public int BibleId { get; set; }
        public Bible Bible { get; set; }
    }
}
