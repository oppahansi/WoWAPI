using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Common
{
    [Table("reputation_reward_rate")]
    public class ReputationRewardRateBase
    {
        [Key]
        public uint Faction { get; set; }
        public float QuestRate { get; set; }
        public float CreatureRate { get; set; }
        public float SpellRate { get; set; }
    }
}
