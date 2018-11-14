using wowapi.Entities.Enumerations;
using System.Collections.Generic;
using wowapi.Entities.Dictionaries;
using wowapi.Entities.Models.Classic;

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

        public static IEnumerable<string> GetResistances(CCreatureTemplate creatureTemplate)
        {
            var resistances = new List<string>();

            if (creatureTemplate.ResistanceFire != 0)
            {
                if (creatureTemplate.ResistanceFire > 0) resistances.Add($"Fire resistance: {creatureTemplate.ResistanceFire}");
                else resistances.Add($"Fire resistance: Immune");
            }

            if (creatureTemplate.ResistanceNature != 0)
            {
                if (creatureTemplate.ResistanceNature > 0) resistances.Add($"Nature resistance: {creatureTemplate.ResistanceNature}");
                else resistances.Add($"Nature resistance: Immune");
            }

            if (creatureTemplate.ResistanceFrost != 0)
            {
                if (creatureTemplate.ResistanceFrost > 0) resistances.Add($"Frost resistance: {creatureTemplate.ResistanceFrost}");
                else resistances.Add($"Frost resistance: Immune");
            }

            if (creatureTemplate.ResistanceShadow != 0)
            {
                if (creatureTemplate.ResistanceShadow > 0) resistances.Add($"Shadow resistance: {creatureTemplate.ResistanceShadow}");
                else resistances.Add($"Shadow resistance: Immune");
            }

            if (creatureTemplate.ResistanceArcane != 0)
            {
                if (creatureTemplate.ResistanceArcane > 0) resistances.Add($"Frost resistance: {creatureTemplate.ResistanceArcane}");
                else resistances.Add($"Arcane resistance: Immune");
            }

            return resistances;
        }
    }
}
