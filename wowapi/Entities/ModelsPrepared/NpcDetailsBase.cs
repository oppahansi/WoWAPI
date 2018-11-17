using System.Collections;
using System.Collections.Generic;
using wowapi.Dictionaries;
using wowapi.Entities.Models.Classic;
using wowapi.Entities.Models.Tbc;
using wowapi.Entities.Models.Wotlk;

namespace wowapi.Entities.ModelsPrepared
{
    public class NpcDetailsBase
    {
        public uint Entry { get; }
        public string Name { get; }
        public string SubName { get; }
        public byte MinLevel { get; }
        public byte MaxLevel { get; }
        public byte CreatureType { get; }
        public byte Rank { get; }
        public string ReactAlliance { get; }
        public string ReactHorde { get; }

        public NpcDetailsBase(CCreatureTemplate creatureTemplate)
        {
            Entry = creatureTemplate.Entry;
            Name = creatureTemplate.Name;
            SubName = creatureTemplate.SubName;
            MinLevel = creatureTemplate.MinLevel;
            MaxLevel = creatureTemplate.MaxLevel;
            CreatureType = creatureTemplate.CreatureType;
            Rank = creatureTemplate.Rank;
            // ReactAlliance
            // ReactHorde
        }

        public NpcDetailsBase(TCreatureTemplate creatureTemplate)
        {
            Entry = creatureTemplate.Entry;
            Name = creatureTemplate.Name;
            SubName = creatureTemplate.SubName;
            MinLevel = creatureTemplate.MinLevel;
            MaxLevel = creatureTemplate.MaxLevel;
            CreatureType = creatureTemplate.CreatureType;
            Rank = creatureTemplate.Rank;
        }

        public NpcDetailsBase(WCreatureTemplate creatureTemplate)
        {
            Entry = creatureTemplate.Entry;
            Name = creatureTemplate.Name;
            SubName = creatureTemplate.SubName;
            MinLevel = creatureTemplate.MinLevel;
            MaxLevel = creatureTemplate.MaxLevel;
            CreatureType = creatureTemplate.Type;
            Rank = creatureTemplate.Rank;
        }
    }
}
