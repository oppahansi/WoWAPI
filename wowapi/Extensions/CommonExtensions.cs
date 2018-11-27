using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wowapi.Models.Db.Classic;
using wowapi.Models.Db.Common;
using wowapi.Models.Db.Dbc;
using wowapi.Models.Search;

namespace wowapi.Extensions
{
    public static class CommonExtensions
    {
        public static bool IsEmpty(this CreatureFilterParams creatureFilterParams)
        {
            return
            string.IsNullOrEmpty(creatureFilterParams.Name) &&
            string.IsNullOrEmpty(creatureFilterParams.SubName) &&
            creatureFilterParams.MinLevel == 0 &&
            creatureFilterParams.MaxLevel == 0 &&
            creatureFilterParams.Family == 0 && 
            creatureFilterParams.Type == 100 &&
            creatureFilterParams.NpcFlags == 0 &&
            creatureFilterParams.ExtraFlags == 0 &&
            creatureFilterParams.MechanicImmuneMask == 0 &&
            creatureFilterParams.SchoolImmuneMask == 0 &&
            creatureFilterParams.Civilian == 2;
        }

        public static bool IsEmpty(this ItemFilterParams itemFilterParams)
        {
            return
            string.IsNullOrEmpty(itemFilterParams.Name) &&
            string.IsNullOrEmpty(itemFilterParams.Description) &&
            itemFilterParams.Class == 100 &&
            itemFilterParams.Subclass == 100 &&
            itemFilterParams.Quality == 100 &&
            itemFilterParams.Flags == 0 &&
            itemFilterParams.InventoryType == 100 &&
            itemFilterParams.AllowableClass == -2 &&
            itemFilterParams.AllowableRace == -2 &&
            itemFilterParams.RequiredLevel == 0 &&
            itemFilterParams.RequiredSkill == 0 &&
            itemFilterParams.RequiredSkillRank == 0 &&
            itemFilterParams.RequiredSpell == 0 &&
            itemFilterParams.RequiredHonorRank == 0 &&
            itemFilterParams.RequiredCityRank == 0 &&
            itemFilterParams.RequiredReputationFaction == 0 &&
            itemFilterParams.RequiredReputationRank == 0 &&
            itemFilterParams.ContainerSlots == 0 &&
            itemFilterParams.StatType == 100 &&
            itemFilterParams.StatValue == 0 &&
            itemFilterParams.Dps == 0 &&
            itemFilterParams.DmgMin == 0 &&
            itemFilterParams.DmgMax == 0 &&
            itemFilterParams.DmgType == 100 &&
            itemFilterParams.Armor == 0 &&
            itemFilterParams.Resistance == 0 &&
            itemFilterParams.HolyRes == 0 &&
            itemFilterParams.FireRes == 0 &&
            itemFilterParams.NatureRes == 0 &&
            itemFilterParams.FrostRes == 0 &&
            itemFilterParams.ShadowRes == 0 &&
            itemFilterParams.ArcaneRes == 0 &&
            itemFilterParams.Speed == 0 &&
            itemFilterParams.AmmoType == 0 &&
            itemFilterParams.SpellTrigger == 100 &&
            itemFilterParams.Bonding == 0 &&
            itemFilterParams.StartQuest == 0 &&
            itemFilterParams.LockId == 0 &&
            itemFilterParams.Material == 0 &&
            itemFilterParams.Sheath == 0 &&
            itemFilterParams.Block == 0 &&
            itemFilterParams.ItemSet == 0 &&
            itemFilterParams.Durability == 0 &&
            itemFilterParams.Area == 100 &&
            itemFilterParams.Map == 100 &&
            itemFilterParams.BagFamily == 0 &&
            itemFilterParams.DisenchantId == 0 &&
            itemFilterParams.FoodType == 0 &&
            itemFilterParams.MoneyLoot == 0 &&
            itemFilterParams.Duration == 0 &&
            itemFilterParams.Entries.Count() == 0;
        }

        public static bool IsEmpty(this ItemSetFilterParams itemSetFilterParams)
        {
            return 
            string.IsNullOrEmpty(itemSetFilterParams.Name) &&
            itemSetFilterParams.ItemEntry == 0;
        }

        public static IEnumerable<CCreatureTemplate> OrderCreatureTemplates(this IEnumerable<CCreatureTemplate> qry, string sortOrder)
        {
            switch (sortOrder.ToLower())
            {
                case "subname":
                    return qry.OrderBy(x => x.SubName).ThenBy(x => x.Name);
                case "minLevel":
                    return qry.OrderBy(x => x.MinLevel).ThenBy(x => x.Name);
                case "maxlevel":
                    return qry.OrderBy(x => x.MaxLevel).ThenBy(x => x.Name);
                case "family":
                    return qry.OrderBy(x => x.SubName).ThenBy(x => x.Name);
                case "type":
                    return qry.OrderBy(x => x.CreatureType).ThenBy(x => x.Name);
                case "npcflags":
                    return qry.OrderBy(x => x.NpcFlags).ThenBy(x => x.Name);
                case "extraflags":
                    return qry.OrderBy(x => x.ExtraFlags).ThenBy(x => x.Name);
                case "mechanicimmune":
                    return qry.OrderBy(x => x.MechanicImmuneMask).ThenBy(x => x.Name);
                case "schoolimmune":
                    return qry.OrderBy(x => x.SchoolImmuneMask).ThenBy(x => x.Name);
                case "civilian":
                    return qry.OrderBy(x => x.Civilian).ThenBy(x => x.Name);
                case "name_desc":
                    return qry.OrderByDescending(x => x.Name);
                case "subname_desc":
                    return qry.OrderByDescending(x => x.SubName).ThenByDescending(x => x.Name);
                case "minLevel_desc":
                    return qry.OrderByDescending(x => x.MinLevel).ThenByDescending(x => x.Name);
                case "maxlevel_desc":
                    return qry.OrderByDescending(x => x.MaxLevel).ThenByDescending(x => x.Name);
                case "family_desc":
                    return qry.OrderByDescending(x => x.SubName).ThenByDescending(x => x.Name);
                case "type_desc":
                    return qry.OrderByDescending(x => x.CreatureType).ThenByDescending(x => x.Name);
                case "npcflags_desc":
                    return qry.OrderByDescending(x => x.NpcFlags).ThenByDescending(x => x.Name);
                case "extraflags_desc":
                    return qry.OrderByDescending(x => x.ExtraFlags).ThenByDescending(x => x.Name);
                case "mechanicimmune_desc":
                    return qry.OrderByDescending(x => x.MechanicImmuneMask).ThenByDescending(x => x.Name);
                case "schoolimmune_desc":
                    return qry.OrderByDescending(x => x.SchoolImmuneMask).ThenByDescending(x => x.Name);
                case "civilian_desc":
                    return qry.OrderByDescending(x => x.Civilian).ThenByDescending(x => x.Name);
                default:
                    return qry.OrderBy(x => x.Name);
            }
        }

        public static IEnumerable<CItemTemplate> OrderItemTemplates(this IEnumerable<CItemTemplate> qry, string sortOrder)
        {
            switch (sortOrder.ToLower())
            {
                case "class":
                    return qry.OrderBy(x => x.Class).ThenBy(x => x.Name);
                case "subclass":
                    return qry.OrderBy(x => x.Subclass).ThenBy(x => x.Name);
                case "quality":
                    return qry.OrderBy(x => x.Quality).ThenBy(x => x.Name);
                case "flags":
                    return qry.OrderBy(x => x.Flags).ThenBy(x => x.Name);
                case "inventorytype":
                    return qry.OrderBy(x => x.InventoryType).ThenBy(x => x.Name);
                case "allowableclass":
                    return qry.OrderBy(x => x.AllowableClass).ThenBy(x => x.Name);
                case "allowablerace":
                    return qry.OrderBy(x => x.AllowableRace).ThenBy(x => x.Name);
                case "reqlevel":
                    return qry.OrderBy(x => x.RequiredLevel).ThenBy(x => x.Name);
                case "reqskill":
                    return qry.OrderBy(x => x.RequiredSkill).ThenBy(x => x.Name);
                case "reqskillrank":
                    return qry.OrderBy(x => x.RequiredSkillRank).ThenBy(x => x.Name);
                case "reqspell":
                    return qry.OrderBy(x => x.Requiredspell).ThenBy(x => x.Name);
                case "reqhonorrank":
                    return qry.OrderBy(x => x.Requiredhonorrank).ThenBy(x => x.Name);
                case "reqcityrank":
                    return qry.OrderBy(x => x.RequiredCityRank).ThenBy(x => x.Name);
                case "reqrepfaction":
                    return qry.OrderBy(x => x.RequiredReputationFaction).ThenBy(x => x.Name);
                case "reqreprank":
                    return qry.OrderBy(x => x.RequiredReputationRank).ThenBy(x => x.Name);
                case "containerslots":
                    return qry.OrderBy(x => x.ContainerSlots).ThenBy(x => x.Name);
                case "dmgmin1":
                    return qry.OrderBy(x => x.DmgMin1).ThenBy(x => x.Name);
                case "dmgmax1":
                    return qry.OrderBy(x => x.DmgMax1).ThenBy(x => x.Name);
                case "dmgtype1":
                    return qry.OrderBy(x => x.DmgType1).ThenBy(x => x.Name);
                case "dmgmin2":
                    return qry.OrderBy(x => x.DmgMin2).ThenBy(x => x.Name);
                case "dmgmax2":
                    return qry.OrderBy(x => x.DmgMax2).ThenBy(x => x.Name);
                case "dmgtype2":
                    return qry.OrderBy(x => x.DmgType2).ThenBy(x => x.Name);
                case "holyres":
                    return qry.OrderBy(x => x.HolyRes).ThenBy(x => x.Name);
                case "fireres":
                    return qry.OrderBy(x => x.FireRes).ThenBy(x => x.Name);
                case "natureres":
                    return qry.OrderBy(x => x.NatureRes).ThenBy(x => x.Name);
                case "frostres":
                    return qry.OrderBy(x => x.FrostRes).ThenBy(x => x.Name);
                case "shadowres":
                    return qry.OrderBy(x => x.ShadowRes).ThenBy(x => x.Name);
                case "arcaneres":
                    return qry.OrderBy(x => x.ArcaneRes).ThenBy(x => x.Name);
                case "speed":
                    return qry.OrderBy(x => x.Delay).ThenBy(x => x.Name);
                case "ammotype":
                    return qry.OrderBy(x => x.AmmoType).ThenBy(x => x.Name);
                case "spelltrigger":
                    return qry.OrderBy(x => x.Spelltrigger1).ThenBy(x => x.Name);
                case "bonding":
                    return qry.OrderBy(x => x.Bonding).ThenBy(x => x.Name);
                case "description":
                    return qry.OrderBy(x => x.Description).ThenBy(x => x.Name);
                case "startq":
                    return qry.OrderBy(x => x.Startquest).ThenBy(x => x.Name);
                case "lockid":
                    return qry.OrderBy(x => x.Lockid).ThenBy(x => x.Name);
                case "material":
                    return qry.OrderBy(x => x.Material).ThenBy(x => x.Name);
                case "sheath":
                    return qry.OrderBy(x => x.Sheath).ThenBy(x => x.Name);
                case "block":
                    return qry.OrderBy(x => x.Block).ThenBy(x => x.Name);
                case "itemset":
                    return qry.OrderBy(x => x.Itemset).ThenBy(x => x.Name);
                case "durability":
                    return qry.OrderBy(x => x.MaxDurability).ThenBy(x => x.Name);
                case "area":
                    return qry.OrderBy(x => x.Area).ThenBy(x => x.Name);
                case "map":
                    return qry.OrderBy(x => x.Map).ThenBy(x => x.Name);
                case "bagfamily":
                    return qry.OrderBy(x => x.BagFamily).ThenBy(x => x.Name);
                case "disid":
                    return qry.OrderBy(x => x.DisenchantId).ThenBy(x => x.Name);
                case "foodtype":
                    return qry.OrderBy(x => x.FoodType).ThenBy(x => x.Name);
                case "moneyloot":
                    return qry.OrderBy(x => x.MaxMoneyLoot).ThenBy(x => x.Name);
                case "duration":
                    return qry.OrderBy(x => x.Duration).ThenBy(x => x.Name);
                case "name_desc":
                    return qry.OrderByDescending(x => x.Name);
                case "class_desc":
                    return qry.OrderByDescending(x => x.Class).ThenByDescending(x => x.Name);
                case "subclass_desc":
                    return qry.OrderByDescending(x => x.Subclass).ThenByDescending(x => x.Name);
                case "quality_desc":
                    return qry.OrderByDescending(x => x.Quality).ThenByDescending(x => x.Name);
                case "flags_desc":
                    return qry.OrderByDescending(x => x.Flags).ThenByDescending(x => x.Name);
                case "inventorytype_desc":
                    return qry.OrderByDescending(x => x.InventoryType).ThenByDescending(x => x.Name);
                case "allowableclass_desc":
                    return qry.OrderByDescending(x => x.AllowableClass).ThenByDescending(x => x.Name);
                case "allowablerace_desc":
                    return qry.OrderByDescending(x => x.AllowableRace).ThenByDescending(x => x.Name);
                case "reqlevel_desc":
                    return qry.OrderByDescending(x => x.RequiredLevel).ThenByDescending(x => x.Name);
                case "reqskill_desc":
                    return qry.OrderByDescending(x => x.RequiredSkill).ThenByDescending(x => x.Name);
                case "reqskillrank_desc":
                    return qry.OrderByDescending(x => x.RequiredSkillRank).ThenByDescending(x => x.Name);
                case "reqspell_desc":
                    return qry.OrderByDescending(x => x.Requiredspell).ThenByDescending(x => x.Name);
                case "reqhonorrank_desc":
                    return qry.OrderByDescending(x => x.Requiredhonorrank).ThenByDescending(x => x.Name);
                case "reqcityrank_desc":
                    return qry.OrderByDescending(x => x.RequiredCityRank).ThenByDescending(x => x.Name);
                case "reqrepfaction_desc":
                    return qry.OrderByDescending(x => x.RequiredReputationFaction).ThenByDescending(x => x.Name);
                case "reqreprank_desc":
                    return qry.OrderByDescending(x => x.RequiredReputationRank).ThenByDescending(x => x.Name);
                case "containerslots_desc":
                    return qry.OrderByDescending(x => x.ContainerSlots).ThenByDescending(x => x.Name);
                case "dmgmin1_desc":
                    return qry.OrderByDescending(x => x.DmgMin1).ThenByDescending(x => x.Name);
                case "dmgmax1_desc":
                    return qry.OrderByDescending(x => x.DmgMax1).ThenByDescending(x => x.Name);
                case "dmgtype1_desc":
                    return qry.OrderByDescending(x => x.DmgType1).ThenByDescending(x => x.Name);
                case "dmgmin2_desc":
                    return qry.OrderByDescending(x => x.DmgMin2).ThenByDescending(x => x.Name);
                case "dmgmax2_desc":
                    return qry.OrderByDescending(x => x.DmgMax2).ThenByDescending(x => x.Name);
                case "dmgtype2_desc":
                    return qry.OrderByDescending(x => x.DmgType2).ThenByDescending(x => x.Name);
                case "holyres_desc":
                    return qry.OrderByDescending(x => x.HolyRes).ThenByDescending(x => x.Name);
                case "fireres_desc":
                    return qry.OrderByDescending(x => x.FireRes).ThenByDescending(x => x.Name);
                case "natureres_desc":
                    return qry.OrderByDescending(x => x.NatureRes).ThenByDescending(x => x.Name);
                case "frostres_desc":
                    return qry.OrderByDescending(x => x.FrostRes).ThenByDescending(x => x.Name);
                case "shadowres_desc":
                    return qry.OrderByDescending(x => x.ShadowRes).ThenByDescending(x => x.Name);
                case "arcaneres_desc":
                    return qry.OrderByDescending(x => x.ArcaneRes).ThenByDescending(x => x.Name);
                case "speed_desc":
                    return qry.OrderByDescending(x => x.Delay).ThenByDescending(x => x.Name);
                case "ammotype_desc":
                    return qry.OrderByDescending(x => x.AmmoType).ThenByDescending(x => x.Name);
                case "spelltrigger_desc":
                    return qry.OrderByDescending(x => x.Spelltrigger1).ThenByDescending(x => x.Name);
                case "bonding_desc":
                    return qry.OrderByDescending(x => x.Bonding).ThenByDescending(x => x.Name);
                case "description_desc":
                    return qry.OrderByDescending(x => x.Description).ThenByDescending(x => x.Name);
                case "startq_desc":
                    return qry.OrderByDescending(x => x.Startquest).ThenByDescending(x => x.Name);
                case "lockid_desc":
                    return qry.OrderByDescending(x => x.Lockid).ThenByDescending(x => x.Name);
                case "material_desc":
                    return qry.OrderByDescending(x => x.Material).ThenByDescending(x => x.Name);
                case "sheath_desc":
                    return qry.OrderByDescending(x => x.Sheath).ThenByDescending(x => x.Name);
                case "block_desc":
                    return qry.OrderByDescending(x => x.Block).ThenByDescending(x => x.Name);
                case "itemset_desc":
                    return qry.OrderByDescending(x => x.Itemset).ThenByDescending(x => x.Name);
                case "durability_desc":
                    return qry.OrderByDescending(x => x.MaxDurability).ThenByDescending(x => x.Name);
                case "area_desc":
                    return qry.OrderByDescending(x => x.Area).ThenByDescending(x => x.Name);
                case "map_desc":
                    return qry.OrderByDescending(x => x.Map).ThenByDescending(x => x.Name);
                case "bagfamily_desc":
                    return qry.OrderByDescending(x => x.BagFamily).ThenByDescending(x => x.Name);
                case "disid_desc":
                    return qry.OrderByDescending(x => x.DisenchantId).ThenByDescending(x => x.Name);
                case "foodtype_desc":
                    return qry.OrderByDescending(x => x.FoodType).ThenByDescending(x => x.Name);
                case "moneyloot_desc":
                    return qry.OrderByDescending(x => x.MaxMoneyLoot).ThenByDescending(x => x.Name);
                case "duration_desc":
                    return qry.OrderByDescending(x => x.Duration).ThenByDescending(x => x.Name);
                default:
                    return qry.OrderBy(x => x.Name);
            }
        }

        public static IEnumerable<CItemSet> OrderItemSets(this IEnumerable<CItemSet> qry, string sortOrder)
        {
            switch (sortOrder.ToLower())
            {
                case "item1":
                    return qry.OrderBy(x => x.Item1).ThenBy(x => x.Name);
                case "item2":
                    return qry.OrderBy(x => x.Item2).ThenBy(x => x.Name);
                case "item3":
                    return qry.OrderBy(x => x.Item3).ThenBy(x => x.Name);
                case "item4":
                    return qry.OrderBy(x => x.Item4).ThenBy(x => x.Name);
                case "item5":
                    return qry.OrderBy(x => x.Item5).ThenBy(x => x.Name);
                case "item6":
                    return qry.OrderBy(x => x.Item6).ThenBy(x => x.Name);
                case "item7":
                    return qry.OrderBy(x => x.Item7).ThenBy(x => x.Name);
                case "item8":
                    return qry.OrderBy(x => x.Item8).ThenBy(x => x.Name);
                case "item9":
                    return qry.OrderBy(x => x.Item9).ThenBy(x => x.Name);
                case "item10":
                    return qry.OrderBy(x => x.Item10).ThenBy(x => x.Name);
                case "item1_desc":
                    return qry.OrderByDescending(x => x.Item1).ThenByDescending(x => x.Name);
                case "item2_desc":
                    return qry.OrderByDescending(x => x.Item2).ThenByDescending(x => x.Name);
                case "item3_desc":
                    return qry.OrderByDescending(x => x.Item3).ThenByDescending(x => x.Name);
                case "item4_desc":
                    return qry.OrderByDescending(x => x.Item4).ThenByDescending(x => x.Name);
                case "item5_desc":
                    return qry.OrderByDescending(x => x.Item5).ThenByDescending(x => x.Name);
                case "item6_desc":
                    return qry.OrderByDescending(x => x.Item6).ThenByDescending(x => x.Name);
                case "item7_desc":
                    return qry.OrderByDescending(x => x.Item7).ThenByDescending(x => x.Name);
                case "item8_desc":
                    return qry.OrderByDescending(x => x.Item8).ThenByDescending(x => x.Name);
                case "item9_desc":
                    return qry.OrderByDescending(x => x.Item9).ThenByDescending(x => x.Name);
                case "item10_desc":
                    return qry.OrderByDescending(x => x.Item10).ThenByDescending(x => x.Name);
                case "name_desc":
                    return qry.OrderByDescending(x => x.Name);
                default:
                    return qry.OrderBy(x => x.Name);
            }
        }

        public static List<Func<CCreatureTemplate, bool>> AsFilters(this CreatureFilterParams filterParams)
        {
            var filters = new List<Func<CCreatureTemplate, bool>>();

            if (!string.IsNullOrEmpty(filterParams.Name))
                filters.Add(x => x.Name.ToLower().CompareTo(filterParams.Name.ToLower()) == 0 || x.Name.ToLower().Contains(filterParams.Name.ToLower()));

            if (!string.IsNullOrEmpty(filterParams.SubName)) 
            {
                filters.Add(x => 
                {
                    if (!string.IsNullOrEmpty(x.SubName))
                        return x.SubName.ToLower().CompareTo(filterParams.SubName.ToLower()) == 0 || x.SubName.ToLower().Contains(filterParams.SubName.ToLower());
                    else
                        return false;
                });
            }

            if (filterParams.MinLevel != 0)
                filters.Add(x => x.MinLevel == filterParams.MinLevel);

            if (filterParams.MaxLevel != 0)
                filters.Add(x => x.MaxLevel == filterParams.MaxLevel);

            if (filterParams.Family != 0)
            {
                filterParams.FilterType = 0;
                filterParams.Type = 1;
                filters.Add(x => x.Family == filterParams.Family);
            }

            if (filterParams.Type != 100)
                filters.Add(x => x.CreatureType == filterParams.Type);

            if (filterParams.NpcFlags != 0)
                filters.Add(x => (x.NpcFlags & (uint)filterParams.NpcFlags) == (uint)filterParams.NpcFlags);

            if (filterParams.ExtraFlags != 0)
                filters.Add(x => (x.ExtraFlags & (uint)filterParams.ExtraFlags) == (uint)filterParams.ExtraFlags);

            if (filterParams.MechanicImmuneMask != 0)
                filters.Add(x => (x.MechanicImmuneMask & (uint)filterParams.MechanicImmuneMask) == (uint)filterParams.MechanicImmuneMask);

            if (filterParams.SchoolImmuneMask != 0)
                filters.Add(x => (x.SchoolImmuneMask & (uint)filterParams.SchoolImmuneMask) == (uint)filterParams.SchoolImmuneMask);

            if (filterParams.Civilian != 2)
                filters.Add(x => x.Civilian == filterParams.Civilian);

            return filters;
        }

        public static List<Func<CItemTemplate, bool>> AsFilters(this ItemFilterParams filterParams)
        {
            var filters = new List<Func<CItemTemplate, bool>>();

            if (!string.IsNullOrEmpty(filterParams.Name))
                filters.Add(x => x.Name.ToLower().CompareTo(filterParams.Name.ToLower()) == 0 || x.Name.ToLower().Contains(filterParams.Name.ToLower()));

            if (!string.IsNullOrEmpty(filterParams.Description))
            {
                filters.Add(x => 
                {
                    if (!string.IsNullOrEmpty(x.Description))
                        return x.Description.ToLower().CompareTo(filterParams.Description.ToLower()) == 0 || x.Description.ToLower().Contains(filterParams.Description.ToLower());
                    else
                        return false;
                });
            }

            if (filterParams.Class != 100)
                filters.Add(x => x.Class == filterParams.Class);

            if (filterParams.Subclass != 100)
                filters.Add(x => x.Subclass == filterParams.Subclass);

            if (filterParams.Quality != 100)
                filters.Add(x => x.Quality == filterParams.Quality);

            if (filterParams.Flags != 0)
                filters.Add(x => x.Flags == filterParams.Flags);

            if (filterParams.InventoryType != 100)
                filters.Add(x => x.InventoryType == filterParams.InventoryType);

            if (filterParams.AllowableClass != -2)
                filters.Add(x => x.AllowableClass == filterParams.AllowableClass);

            if (filterParams.AllowableRace != -2)
                filters.Add(x => x.AllowableRace == filterParams.AllowableRace);
            
            if (filterParams.RequiredLevel != 0)
                filters.Add(x => x.RequiredLevel == filterParams.RequiredLevel);

            if (filterParams.RequiredSkill != 0)
                filters.Add(x => x.RequiredSkill == filterParams.RequiredSkill);
            
            if (filterParams.RequiredSkillRank != 0)
                filters.Add(x => x.RequiredSkillRank == filterParams.RequiredSkillRank);

            if (filterParams.RequiredSpell != 0)
                filters.Add(x => x.Requiredspell == filterParams.RequiredSpell);

            if (filterParams.RequiredHonorRank != 0)
                filters.Add(x => x.Requiredhonorrank == filterParams.RequiredHonorRank);
            
            if (filterParams.RequiredCityRank != 0)
                filters.Add(x => x.RequiredCityRank == filterParams.RequiredCityRank);

            if (filterParams.RequiredReputationFaction != 0)
                filters.Add(x => x.RequiredReputationFaction == filterParams.RequiredReputationFaction);

            if (filterParams.RequiredReputationRank != 0)
                filters.Add(x => x.RequiredReputationRank == filterParams.RequiredReputationRank);

            if (filterParams.ContainerSlots != 0)
                filters.Add(x => x.ContainerSlots == filterParams.ContainerSlots);

            if (filterParams.StatType != 100)
            {
                filters.Add(x =>
                {
                    if (x.StatType1 == filterParams.StatType)
                    {
                        if (filterParams.StatValue != 0) return x.StatValue1 == filterParams.StatValue;
                        else return true;
                    }
                    else if (x.StatType2 == filterParams.StatType)
                    {
                        if (filterParams.StatValue != 0) return x.StatValue2 == filterParams.StatValue;
                        else return true;
                    }
                    else if (x.StatType3 == filterParams.StatType)
                    {
                        if (filterParams.StatValue != 0) return x.StatValue3 == filterParams.StatValue;
                        else return true;
                    }
                    else if (x.StatType4 == filterParams.StatType)
                    {
                        if (filterParams.StatValue != 0) return x.StatValue4 == filterParams.StatValue;
                        else return true;
                    }
                    else if (x.StatType5 == filterParams.StatType)
                    {
                        if (filterParams.StatValue != 0) return x.StatValue5 == filterParams.StatValue;
                        else return true;
                    }
                    else if (x.StatType6 == filterParams.StatType)
                    {
                        if (filterParams.StatValue != 0) return x.StatValue6 == filterParams.StatValue;
                        else return true;
                    }
                    else if (x.StatType7 == filterParams.StatType)
                    {
                        if (filterParams.StatValue != 0) return x.StatValue7 == filterParams.StatValue;
                        else return true;
                    }
                    else if (x.StatType8 == filterParams.StatType)
                    {
                        if (filterParams.StatValue != 0) return x.StatValue8 == filterParams.StatValue;
                        else return true;
                    }
                    else if (x.StatType9 == filterParams.StatType)
                    {
                        if (filterParams.StatValue != 0) return x.StatValue9 == filterParams.StatValue;
                        else return true;
                    }
                    else if (x.StatType10 == filterParams.StatType)
                    {
                        if (filterParams.StatValue != 0) return x.StatValue10 == filterParams.StatValue;
                        else return true;
                    }
                    else return false;
                });
            }
            
            if (filterParams.Dps != 0)
                filters.Add(x => x.CalculateItemDps() == filterParams.Dps);
            
            if (filterParams.DmgMin != 0)
                filters.Add(x => x.DmgMin1 == filterParams.DmgMin || x.DmgMin2 == filterParams.DmgMin);

            if (filterParams.DmgMax != 0)
                filters.Add(x => x.DmgMax1 == filterParams.DmgMax || x.DmgMax2 == filterParams.DmgMax);
            
            if (filterParams.DmgType != 100)
                filters.Add(x => x.DmgType1 == filterParams.DmgType || x.DmgType2 == filterParams.DmgType);

            if (filterParams.Armor != 0)
                filters.Add(x => x.Armor == filterParams.Armor);

            if (filterParams.Resistance != 0)
                filters.Add(x => 
                x.HolyRes == filterParams.Resistance ||
                x.FireRes == filterParams.Resistance ||
                x.NatureRes == filterParams.Resistance ||
                x.FrostRes == filterParams.Resistance ||
                x.ShadowRes == filterParams.Resistance ||
                x.ArcaneRes == filterParams.Resistance);

            if (filterParams.HolyRes != 0)
                filters.Add(x => x.HolyRes == filterParams.HolyRes);

            if (filterParams.FireRes != 0)
                filters.Add(x => x.FireRes == filterParams.FireRes);

            if (filterParams.NatureRes != 0)
                filters.Add(x => x.NatureRes == filterParams.NatureRes);

            if (filterParams.FrostRes != 0)
                filters.Add(x => x.FrostRes == filterParams.FrostRes);

            if (filterParams.ShadowRes != 0)
                filters.Add(x => x.ShadowRes == filterParams.ShadowRes);

            if (filterParams.ArcaneRes != 0)
                filters.Add(x => x.ArcaneRes == filterParams.ArcaneRes);

            if (filterParams.Speed != 0)
                filters.Add(x => x.Delay == filterParams.Speed);

            if (filterParams.AmmoType != 0)
                filters.Add(x => x.AmmoType == filterParams.AmmoType);

            if (filterParams.SpellTrigger != 100)
                filters.Add(x =>
                x.Spelltrigger1 == filterParams.SpellTrigger ||
                x.Spelltrigger2 == filterParams.SpellTrigger ||
                x.Spelltrigger3 == filterParams.SpellTrigger ||
                x.Spelltrigger4 == filterParams.SpellTrigger);
            
            if (filterParams.Bonding != 0)
                filters.Add(x => x.Bonding == filterParams.Bonding);

            if (filterParams.StartQuest != 0)
                filters.Add(x => x.Startquest == filterParams.StartQuest);

            if (filterParams.LockId != 0)
                filters.Add(x => x.Lockid == filterParams.LockId);

            if (filterParams.Material != 0)
                filters.Add(x => x.Material == filterParams.Material);

            if (filterParams.Sheath != 0)
                filters.Add(x => x.Sheath == filterParams.Sheath);

            if (filterParams.Block != 0)
                filters.Add(x => x.Block == filterParams.Block);

            if (filterParams.ItemSet != 0)
                filters.Add(x => x.Itemset == filterParams.ItemSet);

            if (filterParams.Durability != 0)
                filters.Add(x => x.MaxDurability == filterParams.Durability);
            
            if (filterParams.Area != 100)
                filters.Add(x => x.Area == filterParams.Area);

            if (filterParams.Map != 100)
                filters.Add(x => x.Map == filterParams.Map);

            if (filterParams.BagFamily != 0)
                filters.Add(x => x.BagFamily == filterParams.BagFamily);

            if (filterParams.DisenchantId != 0)
                filters.Add(x => x.DisenchantId == filterParams.DisenchantId);

            if (filterParams.FoodType != 0)
                filters.Add(x => x.FoodType == filterParams.FoodType);

            if (filterParams.MoneyLoot != 0)
                filters.Add(x => filterParams.MoneyLoot >= x.MinMoneyLoot && filterParams.MoneyLoot <= x.MaxMoneyLoot);

            if (filterParams.Duration != 0)
                filters.Add(x => x.Duration == filterParams.Duration);
            
            if (filterParams.Entries.Count() != 0)
                filters.Add(x => filterParams.Entries.Contains(x.Entry));

            return filters;
        }

        public static List<Func<CItemSet, bool>> AsFilters(this ItemSetFilterParams filterParams)
        {
            var filters = new List<Func<CItemSet, bool>>();

            if (!string.IsNullOrEmpty(filterParams.Name))
                filters.Add(x => x.Name.ToLower().CompareTo(filterParams.Name.ToLower()) == 0 || x.Name.ToLower().Contains(filterParams.Name.ToLower()));

            if (filterParams.ItemEntry != 0)
            {
                filters.Add(x =>
                {
                    return
                        x.Item1 == filterParams.ItemEntry ||
                        x.Item2 == filterParams.ItemEntry ||
                        x.Item3 == filterParams.ItemEntry ||
                        x.Item4 == filterParams.ItemEntry ||
                        x.Item5 == filterParams.ItemEntry ||
                        x.Item6 == filterParams.ItemEntry ||
                        x.Item7 == filterParams.ItemEntry ||
                        x.Item8 == filterParams.ItemEntry ||
                        x.Item9 == filterParams.ItemEntry ||
                        x.Item10 == filterParams.ItemEntry;
                });
            }

            return filters;
        }

        public static float CalculateItemDps(this ItemTemplateBase itemTemplate)
        {
            var speed = itemTemplate.Delay / 1000.0F;
            return (itemTemplate.DmgMin1 / speed + itemTemplate.DmgMax1 / speed) / 2;
        }

        public static string ToCacheString(this IEnumerable<uint> elements)
        {
            var stringBuilder = new StringBuilder();
            foreach (var element in elements.OrderBy(x => x))
                stringBuilder.Append(element);
            
            return stringBuilder.ToString();
        }
    }
}