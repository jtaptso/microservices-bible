using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibleAPI.Model
{
    public class VersetVersion : Common
    {
        [Key]
        public int VersionId { get; set; }
        [Required, Column("Name", Order = 1)]
        public string Name { get; set; }
        [Required, Column("Number", Order = 2)]
        public string Text { get; set; }

        [ForeignKey("Verset")]
        public int VersetId { get; set; }
        public Verset Verset { get; set; }
    }
}
