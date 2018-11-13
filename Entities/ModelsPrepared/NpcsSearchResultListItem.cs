

using Entities.Dictionaries;
using Entities.Models.Classic;

namespace Entities.ModelsPrepared
{
    public class NpcsSearchResultListItem
    {
        public uint Entry { get; }
        public string Name { get; }
        public string SubName { get; }
        public byte MinLevel { get; }
        public byte MaxLevel { get; }
        public string CreatureType { get; }
        public string Rank { get; }
        public ushort FactionAlliance { get; }
        public ushort FactionHorde { get; }

        public NpcsSearchResultListItem(CCreatureTemplate creatureTemplate)
        {
            Entry = creatureTemplate.Entry;
            Name = creatureTemplate.Name;
            SubName = creatureTemplate.SubName;
            MinLevel = creatureTemplate.MinLevel;
            MaxLevel = creatureTemplate.MaxLevel;
            CreatureType = CreatureDictionary.CreatureTypes.ContainsKey(creatureTemplate.CreatureType) ? CreatureDictionary.CreatureTypes[creatureTemplate.CreatureType] : "Type Unspecified";
            Rank = CreatureDictionary.Ranks.ContainsKey(creatureTemplate.Rank) ? CreatureDictionary.Ranks[creatureTemplate.Rank] : "Rank Unspecified";
            FactionAlliance = creatureTemplate.FactionAlliance;
            FactionHorde = creatureTemplate.FactionHorde;
        }
    }
}
