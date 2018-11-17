using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Wotlk
{
    public class WReputationRewardRate : ReputationRewardRateBase
    {
        public float QuestDailyRate { get; set; }
        public float QuestWeeklyRate { get; set; }
        public float QuestMonthlyRate { get; set; }
        public float QuestRepeatableRate { get; set; }
    }
}
