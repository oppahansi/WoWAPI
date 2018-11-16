using System.Collections.Generic;
using wowapi.Entities.Models.Classic;
using wowapi.Utilities;

namespace wowapi.Entities.ModelsPrepared
{
    public class NpcDetails : NpcDetailsBase
    {
        public string Ainame { get; }
        public string ScriptName { get; }
        public uint MinLootGold { get; }
        public uint MaxLootGold { get; }
        public IEnumerable<IEntity> Loot { get; }
        public IEnumerable<string> NpcFlags { get; }
        public IEnumerable<string> ExtraFlags { get; }
        public IEnumerable<string> Immunities { get; }
        public IEnumerable<string> Resistances { get; }

        public NpcDetails(CCreatureTemplate creatureTemplate) : base(creatureTemplate)
        {
            Ainame = creatureTemplate.Ainame;
            ScriptName = creatureTemplate.ScriptName;
            ExtraFlags = CreatureUtils.BreakDownExtraFlags(creatureTemplate.ExtraFlags);
            NpcFlags = CreatureUtils.BreakDownNpcFlags(creatureTemplate.NpcFlags);
            Immunities = CreatureUtils.BreakDownNpcImmunities(creatureTemplate.MechanicImmuneMask);
            Resistances = CreatureUtils.GetResistances(creatureTemplate);
            MinLootGold = creatureTemplate.MinLootGold;
            MaxLootGold = creatureTemplate.MaxLootGold;

        }
    }
}
