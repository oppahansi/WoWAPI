using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Classic
{
    [Table("creature_template_classlevelstats")]
    public class CCreatureTemplateClassLevelStats : IEntity
    {
        [Key]
        public sbyte Level { get; set; }
        [Key]
        public sbyte Class { get; set; }
        public uint BaseHealthExp0 { get; set; }
        public uint BaseMana { get; set; }
        public float BaseDamageExp0 { get; set; }
        public float BaseMeleeAttackPower { get; set; }
        public float BaseRangedAttackPower { get; set; }
        public uint BaseArmor { get; set; }
    }
}
