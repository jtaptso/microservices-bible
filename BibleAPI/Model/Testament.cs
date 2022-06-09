using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibleAPI.Model
{
    [Table("Testament")]
    public class Testament : Common
    {
        [Key]
        public int TestamentId { get; set; }
        public string Name { get; set; }
        public List<Livre> Livres { get; set; }
        [ForeignKey("Language")]
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
