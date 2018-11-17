using System;
using System.Collections.Generic;
using System.Linq;
using wowapi.Entities;
using wowapi.Entities.Models.Classic;
using wowapi.Entities.Models.Search;
using wowapi.Enumerations;

namespace wowapi.Extensions
{
    public static class CRepositoryContextExtensions
    {
        public static void Filter(this CRepositoryContext repositoryContext, ref IEnumerable<CCreatureTemplate> creatureTemplates, CreatureFilterParams filterParams)
        {
            switch (filterParams.FilterType)
            {
                case (byte)CommonEnums.FilterTypes.ALL:
                    FilterAll(ref creatureTemplates, filterParams);
                    break;
                case (byte)CommonEnums.FilterTypes.ANY:
                    FilterAny(ref creatureTemplates, filterParams);
                    break;
                case (byte)CommonEnums.FilterTypes.INVERTED:
                    FilterInverted(ref creatureTemplates, filterParams);
                    break;
            }
        }

        private static void FilterAll(ref IEnumerable<CCreatureTemplate> creatureTemplates, CreatureFilterParams filterParams)
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
                filters.Add(x => x.Family == filterParams.Family);

            if (filterParams.NpcFlags != 0)
                filters.Add(x => (x.NpcFlags & (uint)filterParams.NpcFlags) == (uint)filterParams.NpcFlags);

            if (filterParams.ExtraFlags != 0)
                filters.Add(x => (x.ExtraFlags & (uint)filterParams.ExtraFlags) == (uint)filterParams.ExtraFlags);

            if (filterParams.MechanicImmuneMask != 0)
                filters.Add(x => (x.MechanicImmuneMask & (uint)filterParams.MechanicImmuneMask) == (uint)filterParams.MechanicImmuneMask);
            
            if (filterParams.Civilian != 2)
                filters.Add(x => x.Civilian == filterParams.Civilian);

            creatureTemplates = creatureTemplates.AsParallel().Where(x =>
            {
                return filters.All(f => f(x));
            });
        }

        private static void FilterAny(ref IEnumerable<CCreatureTemplate> creatureTemplates, CreatureFilterParams filterParams)
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
                filters.Add(x => x.Family == filterParams.Family);

            if (filterParams.NpcFlags != 0)
                filters.Add(x => (x.NpcFlags & (uint)filterParams.NpcFlags) == (uint)filterParams.NpcFlags);

            if (filterParams.ExtraFlags != 0)
                filters.Add(x => (x.ExtraFlags & (uint)filterParams.ExtraFlags) == (uint)filterParams.ExtraFlags);

            if (filterParams.MechanicImmuneMask != 0)
                filters.Add(x => (x.MechanicImmuneMask & (uint)filterParams.MechanicImmuneMask) == (uint)filterParams.MechanicImmuneMask);

            if (filterParams.Civilian != 2)
                filters.Add(x => x.Civilian == filterParams.Civilian);

            creatureTemplates = creatureTemplates.AsParallel().Where(x =>
            {
                return filters.Any(f => f(x));
            });
        }

        private static void FilterInverted(ref IEnumerable<CCreatureTemplate> creatureTemplates, CreatureFilterParams filterParams)
        {
            var filters = new List<Func<CCreatureTemplate, bool>>();

            if (!string.IsNullOrEmpty(filterParams.Name))
                filters.Add(x => x.Name.ToLower().CompareTo(filterParams.Name.ToLower()) != 0 || !x.Name.ToLower().Contains(filterParams.Name.ToLower()));

            if (!string.IsNullOrEmpty(filterParams.SubName)) 
            {
                filters.Add(x => 
                {
                    if (!string.IsNullOrEmpty(x.SubName))
                        return x.SubName.ToLower().CompareTo(filterParams.SubName.ToLower()) != 0 || !x.SubName.ToLower().Contains(filterParams.SubName.ToLower());
                    else
                        return false;
                });  
            } 

            if (filterParams.MinLevel != 0)
                filters.Add(x => x.MinLevel != filterParams.MinLevel);

            if (filterParams.MaxLevel != 0)
                filters.Add(x => x.MaxLevel != filterParams.MaxLevel);

            if (filterParams.Family != 0)
                filters.Add(x => x.Family != filterParams.Family);

            if (filterParams.NpcFlags != 0)
                filters.Add(x => (x.NpcFlags & (uint)filterParams.NpcFlags) != (uint)filterParams.NpcFlags);

            if (filterParams.ExtraFlags != 0)
                filters.Add(x => (x.ExtraFlags & (uint)filterParams.ExtraFlags) != (uint)filterParams.ExtraFlags);

            if (filterParams.MechanicImmuneMask != 0)
                filters.Add(x => (x.MechanicImmuneMask & (uint)filterParams.MechanicImmuneMask) != (uint)filterParams.MechanicImmuneMask);

            if (filterParams.Civilian != 2)
                filters.Add(x => x.Civilian != filterParams.Civilian);

            creatureTemplates = creatureTemplates.AsParallel().Where(x =>
            {
                return filters.All(f => f(x));
            });
        }
    }
}