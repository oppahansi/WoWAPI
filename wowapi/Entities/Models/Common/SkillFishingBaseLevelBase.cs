using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Common
{
    [Table("skill_fishing_base_level")]
    public class SkillFishingBaseLevelBase : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        public short Skill { get; set; }
    }
}
