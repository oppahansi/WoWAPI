using wowapi.Enumerations;
using wowapi.Models.Db.Classic;

namespace wowapi.Extensions
{
    public static class CreatureTemplateExtensions
    {
        public static bool IsObjectNull(this CCreatureTemplate creatureTemplatey)
        {
            return creatureTemplatey == null;
        }

        public static bool IsEmptyObject(this CCreatureTemplate creatureTemplate)
        {
            return creatureTemplate.Entry == 0;
        }

        public static bool IsVendor(this CCreatureTemplate creatureTemplate)
        {
            return (creatureTemplate.NpcFlags & (uint)CreatureEnums.NpcFlags.UNIT_NPC_FLAG_VENDOR) == (uint)CreatureEnums.NpcFlags.UNIT_NPC_FLAG_VENDOR;
        }

        public static object CreateResponeObject(this CCreatureTemplate creatureTemplate)
        {
            return new
            {
                Entry = creatureTemplate.Entry,
                Name = creatureTemplate.Name,
                SubName = creatureTemplate.SubName,
                MinLevel = creatureTemplate.MinLevel,
                MaxLevel = creatureTemplate.MaxLevel,
                Rank = creatureTemplate.Rank,
                Faction = creatureTemplate.FactionAlliance,
                //MinHealth =
                //MaxHealth = 
                //MinMeleeDamage =
                //MaxMeleeDamage =
                //MinRangeDamage =
                //MaxRangeDamage =
                //MinLevelMana =
                //MaxLevelMana =
                //Armor =
                DamageSchool = creatureTemplate.DamageSchool,
                MinLootGold = creatureTemplate.MinLootGold,
                MaxLootGold = creatureTemplate.MaxLootGold,
                AiName = creatureTemplate.Ainame,
                ScriptName = creatureTemplate.ScriptName,
                ExtraFlags = creatureTemplate.ExtraFlags,
                SchoolImmuneMask = creatureTemplate.SchoolImmuneMask,
                MechanicImmuneMask = creatureTemplate.MechanicImmuneMask,
                HolyRes = creatureTemplate.ResistanceHoly,
                FireRes = creatureTemplate.ResistanceFire,
                NatureRes = creatureTemplate.ResistanceNature,
                FrostRes = creatureTemplate.ResistanceFrost,
                ShadowRes = creatureTemplate.ResistanceShadow,
                ArcaneRes = creatureTemplate.ResistanceArcane,
                // Drops =
                // Skinning = 
                // Sells =
                // Pickpocketing = 
                // Starts =
                // Ends =
                // Teaches = 
                Civilian = creatureTemplate.Civilian
            };
        }
    }
}
