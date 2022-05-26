using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibleAPI.Model
{
    [Table("Bible")]
    public class Bible : Common
    {
        [Key, Column(Order = 0)]
        public int BibleId { get; set; }
        [Column(Order = 1)]
        public string? Auteur { get; set; }
        [Column(Order = 2)]
        public string? Version { get; set; }
        public List<Livre> Livres { get; set; }
    }
}
