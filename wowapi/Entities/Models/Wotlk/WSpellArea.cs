using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Wotlk
{
    public class WSpellArea : SpellAreaBase
    {
        public int QuestStartStatus { get; set; }
        public int QuestEndStatus { get; set; }
    }
}
