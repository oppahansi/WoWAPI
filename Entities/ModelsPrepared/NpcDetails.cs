using System.Collections.Generic;
using Entities.Models.Classic;
using Utilities;

namespace Entities.ModelsPrepared
{
    public class NpcDetails : NpcDetailsBase
    {
        public string Ainame { get; }
        public string ScriptName { get; }
        public IEnumerable<string> NpcFlags { get; }
        public IEnumerable<string> ExtraFlags { get; set; }
        public IEnumerable<string> Immunities { get; set; }
        public IEnumerable<string> Resistances { get; }

        public NpcDetails(CCreatureTemplate creatureTemplate, IEnumerable<CCreature> spawns) : base(creatureTemplate)
        {
            Ainame = creatureTemplate.Ainame;
            ScriptName = creatureTemplate.ScriptName;
            ExtraFlags = CreatureUtils.BreakDownExtraFlags(creatureTemplate.ExtraFlags);
            MapSpawns = CommonUtils.GetMapSpawns(spawns);
        }
    }
}
