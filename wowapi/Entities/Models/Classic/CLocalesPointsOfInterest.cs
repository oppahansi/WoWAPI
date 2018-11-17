using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Classic
{
    [Table("locales_points_of_interest")]
    public class CLocalesPointsOfInterest : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        public string IconNameLoc1 { get; set; }
        public string IconNameLoc2 { get; set; }
        public string IconNameLoc3 { get; set; }
        public string IconNameLoc4 { get; set; }
        public string IconNameLoc5 { get; set; }
        public string IconNameLoc6 { get; set; }
        public string IconNameLoc7 { get; set; }
        public string IconNameLoc8 { get; set; }
    }
}
