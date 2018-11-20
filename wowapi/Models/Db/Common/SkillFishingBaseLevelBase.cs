using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Common
{
    [Table("skill_fishing_base_level")]
    public class SkillFishingBaseLevelBase
    {
        [Key]
        public uint Entry { get; set; }
        public short Skill { get; set; }
    }
}
