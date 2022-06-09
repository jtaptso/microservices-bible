using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibleAPI.Model
{
    public class Language : Common
    {
        [Key]
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public List<Testament> Testaments { get; set; }
        [ForeignKey("Bible")]
        public int BibleId { get; set; }
        public Bible Bible { get; set; }
    }
}