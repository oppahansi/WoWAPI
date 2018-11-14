using System.Collections.Generic;
using Entities.Models.Classic;

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

        public NpcDetails(CCreatureTemplate creatureTemplate) : base(creatureTemplate)
        {
            Ainame = creatureTemplate.Ainame;
            ScriptName = creatureTemplate.ScriptName;
        }
    }
}
