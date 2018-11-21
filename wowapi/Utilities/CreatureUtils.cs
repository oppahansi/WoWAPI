using System.Collections.Generic;
using wowapi.Dictionaries;
using wowapi.Enumerations;
using wowapi.Models.Db.Classic;

namespace wowapi.Utilities
{
    public static class CreatureUtils
    {
        public static IEnumerable<string> BreakDownExtraFlags(uint extraFlags)
        {
            var extraFlagsList = new List<string>();
            var extraFlagEnumValues = EnumUtil.GetValues<CreatureEnums.CreatureExtraFlags>();

            foreach (var extraFlag in extraFlagEnumValues)
            {
                if ((extraFlags & (uint)extraFlag) == (uint)extraFlag)
                    extraFlagsList.Add(CreatureDictionary.ExtraFlags[(uint)extraFlag]);
            }

            return extraFlagsList;
        }

        public static IEnumerable<string> BreakDownNpcFlags(uint npcFlags)
        {
            var npcFlagList = new List<string>();
            var npcFlagEnumValues = EnumUtil.GetValues<CreatureEnums.NpcFlags>();

            foreach (var npcFlag in npcFlagEnumValues)
            {
                if ((npcFlags & (uint)npcFlag) == (uint)npcFlag)
                    npcFlagList.Add(CreatureDictionary.NpcFlags[(uint)npcFlag]);
            }

            return npcFlagList;
        }

        public static IEnumerable<string> BreakDownNpcImmunities(uint spellMechanicImmuneMask)
        {
            var spellMechanicsList = new List<string>();
            var spellMechanicsEnumValues = EnumUtil.GetValues<CreatureEnums.SpellMechanics>();

            foreach (var spellMechanic in spellMechanicsEnumValues)
            {
                if ((spellMechanicImmuneMask & (uint)spellMechanic) == (uint)spellMechanic)
                    spellMechanicsList.Add(CreatureDictionary.SpellMechanic[(uint)spellMechanic]);
            }

            return spellMechanicsList;
        }

        public static object GetNpcDetailsResponseObject(CCreatureTemplate creatureTemplate)
        {
            return new 
                {
                    Id = creatureTemplate.Entry,
                    Name = creatureTemplate.Name,
                    SubName = creatureTemplate.SubName,
                    MinLevel = creatureTemplate.MinLevel,
                    MaxLevel = creatureTemplate.MaxLevel,
                    CreatureType = creatureTemplate.CreatureType,
                    Rank = creatureTemplate.Rank,
                    Ainame = creatureTemplate.Ainame,
                    ScriptName = creatureTemplate.ScriptName,
                    MinLootGold = creatureTemplate.MinLootGold,
                    MaxLootGold = creatureTemplate.MaxLootGold,
                    LootId = creatureTemplate.LootId,
                    PickpocketLootId = creatureTemplate.PickpocketLootId,
                    SkinningLootId = creatureTemplate.SkinningLootId,
                    VendorTemplateId = creatureTemplate.VendorTemplateId,
                    NpcFlags = creatureTemplate.NpcFlags,
                    ExtraFlags = creatureTemplate.ExtraFlags,
                    MechanicImmunities = creatureTemplate.MechanicImmuneMask,
                    SchoolImmunities = creatureTemplate.SchoolImmuneMask,
                    ResistanceHoly = creatureTemplate.ResistanceHoly,
                    ResistanceFire = creatureTemplate.ResistanceFire,
                    ResistanceNature = creatureTemplate.ResistanceNature,
                    ResistanceFrost = creatureTemplate.ResistanceFrost,
                    ResistanceShadow = creatureTemplate.ResistanceShadow,
                    ResistanceArcane = creatureTemplate.ResistanceArcane
                };
        }
    }
}
