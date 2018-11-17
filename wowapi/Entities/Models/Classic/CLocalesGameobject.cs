using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Classic
{
    [Table("locales_gameobject")]
    public class CLocalesGameobject : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        public string NameLoc1 { get; set; }
        public string NameLoc2 { get; set; }
        public string NameLoc3 { get; set; }
        public string NameLoc4 { get; set; }
        public string NameLoc5 { get; set; }
        public string NameLoc6 { get; set; }
        public string NameLoc7 { get; set; }
        public string NameLoc8 { get; set; }
    }
}
