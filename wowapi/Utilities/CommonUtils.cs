using System;
using System.Collections.Generic;
using System.IO;
using wowapi.Entities.Models.Classic;
using wowapi.Entities.Models.Search;

namespace wowapi.Utilities
{
    public static class CommonUtils
    {
        public static string GetMapNameById(ushort mapId)
        {
            var lines = File.ReadLines(AppContext.BaseDirectory + "/Resources/pre_cata_areas.csv");

            foreach (var line in lines)
            {
                var lineValues = line.Split(",");

                if (ushort.TryParse(lineValues[0], out ushort parsedMapId))
                {
                    if (parsedMapId > mapId || parsedMapId == 0)
                        return "Unspecified";

                    if (parsedMapId == mapId)
                        return lineValues[1];
                }
                else
                    return "Unspecified";
            }

            return "Unspecified";
        }

        public static Dictionary<string, int> GetMapSpawns(IEnumerable<CCreature> spawns)
        {
            var mapSpaws = new Dictionary<string, int>();

            foreach (var spawn in spawns)
            {
                var mapName = GetMapNameById(spawn.Map);
                if (mapSpaws.ContainsKey(mapName)) mapSpaws[mapName] += 1;
                else mapSpaws.Add(mapName, 1);
            }

            return mapSpaws;
        }

        public static List<Func<CCreatureTemplate, bool>> GetCreatureFilters(CreatureFilterParams filterParams)
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

            if (filterParams.Type != 0)
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
    }
}
