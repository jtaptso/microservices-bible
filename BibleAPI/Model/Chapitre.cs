using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibleAPI.Model
{
    [Table("Chapitre")]
    public class Chapitre : Common
    {
        [Key]
        public int ChapitreId { get; set; }
        [Required, Column("Numero", Order = 1)]
        public int Numero { get; set; }
        public List<Verset> Versets { get; set; }
        [ForeignKey("Livre")]
        public int LivreId { get; set; }
        public Livre Livre { get; set; }
        
    }
}
