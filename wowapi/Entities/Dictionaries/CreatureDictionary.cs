using System.Collections.Generic;

namespace wowapi.Entities.Dictionaries
{
    public static class CreatureDictionary
    {
        public static readonly Dictionary<byte, string> CreatureTypes = new Dictionary<byte, string>
        {
            {0, "None"},
            {1, "Beast"},
            {2, "Dragonkin"},
            {3, "Demon"},
            {4, "Elemental"},
            {5, "Giant"},
            {6, "Undead"},
            {7, "Humanoid"},
            {8, "Critter"},
            {9, "Mechanical"},
            {10, "Not specified"},
            {11, "Totem"},
            {12, "Non-combat Pet"},
            {13, "Gas Cloud"}
        };

        public static readonly Dictionary<byte, string> Ranks = new Dictionary<byte, string>
        {
            {0,  "Normal"},
            {1, "Elite"},
            {2, "Rare Elite"},
            {3, "World Boss"},
            {4, "Rare"}
        };

        public static readonly Dictionary<uint, string> ExtraFlags = new Dictionary<uint, string>
        {
            {1,         "Binds to instance" },
            {2,         "Doesn't aggro"},
            {4,         "Can’t parry"},
            {8,         "Can’t counter-attack at parry"},
            {16,        "Can’t block"},
            {32,        "Can’t do crush attacks"},
            {64,        "Kill doesn't provide XP"},
            {128,       "Invisible to players"},
            {256,       "Immune to taunt"},
            {512,       "Sets itself in combat with zone on Aggro"},
            {1024,      "Is a guard"},
            {2048,      "Doesn't call for assistance on aggro"},
            {4096,      "Active object"},
            {8192,      "Uses MMaps"},
            {16384,     "Doesn't use MMaps"},
            {32768,     "Forced to walk in water"},
            {65536,     "Civilian"},
            {131072,    "Can’t melee"},
            {262144,    "With far view"},
            {524288,    "Nonattackable, nontargetable able to attack nontheless"},
            {1048576,   "Ignore used positions"},
            {2097152,   "Count creature spawns in Map"},
            {4194304,   "Immunity to COT or Mind Numbing Poison"}
        };
    }
}
