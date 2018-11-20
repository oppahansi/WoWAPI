using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Wotlk
{
    public class WSpellArea : SpellAreaBase
    {
        public int QuestStartStatus { get; set; }
        public int QuestEndStatus { get; set; }
    }
}
