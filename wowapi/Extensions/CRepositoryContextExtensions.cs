using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using wowapi.Contracts.Classic;
using wowapi.Entities;
using wowapi.Entities.Models.Classic;

namespace wowapi.Extensions
{
    public static class CRepositoryContextExtensions
    {
        public static IEnumerable<CCreatureTemplate> FilterAll(this CRepositoryContext repositoryContext, IEnumerable<CCreatureTemplate> creatureTemplates, CCreatureTemplate queryModel)
        {
            if (!string.IsNullOrEmpty(queryModel.Name))
                creatureTemplates = creatureTemplates.Where(x => x.Name.ToLower().CompareTo(queryModel.Name.ToLower()) == 0 || x.Name.ToLower().Contains(queryModel.Name.ToLower()));

            if (!string.IsNullOrEmpty(queryModel.SubName)) 
                creatureTemplates = creatureTemplates.Where(x => !string.IsNullOrEmpty(x.SubName)).Where(x => x.SubName.ToLower().CompareTo(queryModel.SubName.ToLower()) == 0 || x.SubName.ToLower().Contains(queryModel.SubName.ToLower()));   

            if (queryModel.MinLevel != 0)
                creatureTemplates = creatureTemplates.Where(x => x.MinLevel == queryModel.MinLevel);

            if (queryModel.MaxLevel != 0)
                creatureTemplates = creatureTemplates.Where(x => x.MaxLevel == queryModel.MaxLevel);

            if (queryModel.Family != 0)
                creatureTemplates = creatureTemplates.Where(x => x.Family == queryModel.Family);

            if (queryModel.NpcFlags != 0)
                creatureTemplates = creatureTemplates.Where(x => (x.NpcFlags & (uint)queryModel.NpcFlags) == (uint)queryModel.NpcFlags);

            if (queryModel.ExtraFlags != 0)
                creatureTemplates = creatureTemplates.Where(x => (x.ExtraFlags & (uint)queryModel.ExtraFlags) == (uint)queryModel.ExtraFlags);

            if (queryModel.MechanicImmuneMask != 0)
                creatureTemplates = creatureTemplates.Where(x => (x.MechanicImmuneMask & (uint)queryModel.MechanicImmuneMask) == (uint)queryModel.MechanicImmuneMask);                

            return creatureTemplates;
        }

        public static IEnumerable<CCreatureTemplate> FilterAny(this CRepositoryContext repositoryContext, IEnumerable<CCreatureTemplate> creatureTemplates, CCreatureTemplate queryModel)
        {
            IEnumerable<CCreatureTemplate> filtered = new List<CCreatureTemplate>();

            if (!string.IsNullOrEmpty(queryModel.Name))
                filtered = filtered.Union(creatureTemplates.Where(x => x.Name.ToLower().CompareTo(queryModel.Name.ToLower()) == 0 || x.Name.ToLower().Contains(queryModel.Name.ToLower())));

            if (!string.IsNullOrEmpty(queryModel.SubName)) 
                filtered = filtered.Union(creatureTemplates.Where(x => !string.IsNullOrEmpty(x.SubName)).Where(x => x.SubName.ToLower().CompareTo(queryModel.SubName.ToLower()) == 0 || x.SubName.ToLower().Contains(queryModel.SubName.ToLower())));

            if (queryModel.MinLevel != 0)
                filtered = filtered.Union(creatureTemplates.Where(x => x.MinLevel == queryModel.MinLevel));

            if (queryModel.MaxLevel != 0)
                filtered = filtered.Union(creatureTemplates.Where(x => x.MaxLevel == queryModel.MaxLevel));

            if (queryModel.Family != 0)
                filtered = filtered.Union(creatureTemplates.Where(x => x.Family == queryModel.Family));

            if (queryModel.NpcFlags != 0)
                filtered = filtered.Union(creatureTemplates.Where(x => (x.NpcFlags & (uint)queryModel.NpcFlags) == (uint)queryModel.NpcFlags));

            if (queryModel.ExtraFlags != 0)
                filtered = filtered.Union(creatureTemplates.Where(x => (x.ExtraFlags & (uint)queryModel.ExtraFlags) == (uint)queryModel.ExtraFlags));

            if (queryModel.MechanicImmuneMask != 0)
                filtered = filtered.Union(creatureTemplates.Where(x => (x.MechanicImmuneMask & (uint)queryModel.MechanicImmuneMask) == (uint)queryModel.MechanicImmuneMask));

            return filtered;
        }

        public static IEnumerable<CCreatureTemplate> FilterInverted(this CRepositoryContext repositoryContext, IEnumerable<CCreatureTemplate> creatureTemplates, CCreatureTemplate queryModel)
        {
            IEnumerable<CCreatureTemplate> filtered = new List<CCreatureTemplate>();

            if (!string.IsNullOrEmpty(queryModel.Name))
                filtered = filtered.Union(creatureTemplates.Where(x => x.Name.ToLower().CompareTo(queryModel.Name.ToLower()) != 0 || !x.Name.ToLower().Contains(queryModel.Name.ToLower())));

            if (!string.IsNullOrEmpty(queryModel.SubName)) 
                filtered = filtered.Union(creatureTemplates.Where(x => !string.IsNullOrEmpty(x.SubName)).Where(x => x.SubName.ToLower().CompareTo(queryModel.SubName.ToLower()) != 0 || !x.SubName.ToLower().Contains(queryModel.SubName.ToLower())));

            if (queryModel.MinLevel != 0)
                filtered = filtered.Union(creatureTemplates.Where(x => x.MinLevel != queryModel.MinLevel));

            if (queryModel.MaxLevel != 0)
                filtered = filtered.Union(creatureTemplates.Where(x => x.MaxLevel != queryModel.MaxLevel));

            if (queryModel.Family != 0)
                filtered = filtered.Union(creatureTemplates.Where(x => x.Family != queryModel.Family));

            if (queryModel.NpcFlags != 0)
                filtered = filtered.Union(creatureTemplates.Where(x => (x.NpcFlags & (uint)queryModel.NpcFlags) != (uint)queryModel.NpcFlags));

            if (queryModel.ExtraFlags != 0)
                filtered = filtered.Union(creatureTemplates.Where(x => (x.ExtraFlags & (uint)queryModel.ExtraFlags) != (uint)queryModel.ExtraFlags));

            if (queryModel.MechanicImmuneMask != 0)
                filtered = filtered.Union(creatureTemplates.Where(x => (x.MechanicImmuneMask & (uint)queryModel.MechanicImmuneMask) != (uint)queryModel.MechanicImmuneMask));

            return filtered;
        }
    }
}