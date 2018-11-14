using wowapi.Entities.Models.Classic;
using System;
using System.Collections.Generic;
using System.IO;

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
    }
}
