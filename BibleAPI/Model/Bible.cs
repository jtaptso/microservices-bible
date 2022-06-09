using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibleAPI.Model
{
    [Table("Bible")]
    public class Bible : Common
    {
        [Key]
        public int BibleId { get; set; }
        public List<Language> Languages { get; set; }
    }
}
