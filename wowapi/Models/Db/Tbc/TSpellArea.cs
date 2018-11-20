using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Tbc
{
    public class TSpellArea : SpellAreaBase
    {
        public byte QuestStartActive { get; set; }
        public uint ConditionId { get; set; }
    }
}
