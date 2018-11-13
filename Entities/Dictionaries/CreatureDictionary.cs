using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dictionaries
{
    public static class CreatureDictionary
    {
        public static readonly Dictionary<byte, string> CreatureTypes = new Dictionary<byte, string>()
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

        public static readonly Dictionary<byte, string> Ranks = new Dictionary<byte, string>()
        {
            {0,  "Normal"},
            {1, "Elite"},
            {2, "Rare Elite"},
            {3, "World Boss"},
            {4, "Rare"}
        };
    }
}
