﻿using System;
using System.Collections.Generic;

namespace wowapi.Entities.Dictionaries
{
    public static class ItemDictionary
    {
        public static readonly IEnumerable<Tuple<byte, byte, string>> ItemSubclass = new List<Tuple<byte, byte, string>>
        {
            new Tuple<byte, byte, string>(0, 0, "Consumable"),
            new Tuple<byte, byte, string>(0, 1, "Potion"),
            new Tuple<byte, byte, string>(0, 2, "Elixir"),
            new Tuple<byte, byte, string>(0, 3, "Flask"),
            new Tuple<byte, byte, string>(0, 4, "Scroll"),
            new Tuple<byte, byte, string>(0, 5, "Food & Drink"),
            new Tuple<byte, byte, string>(0, 6, "Item Enhancement"),
            new Tuple<byte, byte, string>(0, 7, "Bandage"),
            new Tuple<byte, byte, string>(0, 8, "Other"),
            new Tuple<byte, byte, string>(1, 0, "Bag"),
            new Tuple<byte, byte, string>(1, 1, "Soul Bag"),
            new Tuple<byte, byte, string>(1, 2, "Herb Bag"),
            new Tuple<byte, byte, string>(1, 3, "Enchanting Bag"),
            new Tuple<byte, byte, string>(1, 4, "Engineering Bag"),
            new Tuple<byte, byte, string>(1, 5, "Gem Bag"),
            new Tuple<byte, byte, string>(1, 6, "Mining Bag"),
            new Tuple<byte, byte, string>(1, 7, "Leatherworking Bag"),
            new Tuple<byte, byte, string>(2, 0, "AxeOne handed"),
            new Tuple<byte, byte, string>(2, 1, "AxeTwo handed"),
            new Tuple<byte, byte, string>(2, 2, "Bow"),
            new Tuple<byte, byte, string>(2, 3, "Gun"),
            new Tuple<byte, byte, string>(2, 4, "MaceOne handed"),
            new Tuple<byte, byte, string>(2, 5, "MaceTwo handed"),
            new Tuple<byte, byte, string>(2, 6, "Polearm"),
            new Tuple<byte, byte, string>(2, 7, "SwordOne handed"),
            new Tuple<byte, byte, string>(2, 8, "SwordTwo handed"),
            new Tuple<byte, byte, string>(2, 9, "Obsolete"),
            new Tuple<byte, byte, string>(2, 10, "Staff"),
            new Tuple<byte, byte, string>(2, 11, "Exotic"),
            new Tuple<byte, byte, string>(2, 12, "Exotic"),
            new Tuple<byte, byte, string>(2, 13, "Fist Weapon"),
            new Tuple<byte, byte, string>(2, 14, "Miscellaneous(Blacksmith Hammer, Mining Pick, etc.)"),
            new Tuple<byte, byte, string>(2, 15, "Dagger"),
            new Tuple<byte, byte, string>(2, 16, "Thrown"),
            new Tuple<byte, byte, string>(2, 17, "Spear"),
            new Tuple<byte, byte, string>(2, 18, "Crossbow"),
            new Tuple<byte, byte, string>(2, 19, "Wand"),
            new Tuple<byte, byte, string>(2, 20, "Fishing Pole"),
            new Tuple<byte, byte, string>(3, 0, "Red"),
            new Tuple<byte, byte, string>(3, 1, "Blue"),
            new Tuple<byte, byte, string>(3, 2, "Yellow"),
            new Tuple<byte, byte, string>(3, 3, "Purple"),
            new Tuple<byte, byte, string>(3, 4, "Green"),
            new Tuple<byte, byte, string>(3, 5, "Orange"),
            new Tuple<byte, byte, string>(3, 6, "Meta"),
            new Tuple<byte, byte, string>(3, 7, "Simple"),
            new Tuple<byte, byte, string>(3, 8, "Prismatic"),
            new Tuple<byte, byte, string>(4, 0, "Miscellaneous"),
            new Tuple<byte, byte, string>(4, 1, "Cloth"),
            new Tuple<byte, byte, string>(4, 2, "Leather"),
            new Tuple<byte, byte, string>(4, 3, "Mail"),
            new Tuple<byte, byte, string>(4, 4, "Plate"),
            new Tuple<byte, byte, string>(4, 5, "Buckler(OBSOLETE)"),
            new Tuple<byte, byte, string>(4, 6, "Shield"),
            new Tuple<byte, byte, string>(4, 7, "Libram"),
            new Tuple<byte, byte, string>(4, 8, "Idol"),
            new Tuple<byte, byte, string>(4, 9, "Totem"),
            new Tuple<byte, byte, string>(5, 0, "Reagent"),
            new Tuple<byte, byte, string>(6, 0, "Wand(OBSOLETE)"),
            new Tuple<byte, byte, string>(6, 1, "Bolt(OBSOLETE)"),
            new Tuple<byte, byte, string>(6, 2, "Arrow"),
            new Tuple<byte, byte, string>(6, 3, "Bullet"),
            new Tuple<byte, byte, string>(6, 4, "Thrown(OBSOLETE)"),
            new Tuple<byte, byte, string>(7, 0, "Trade Goods"),
            new Tuple<byte, byte, string>(7, 1, "Parts"),
            new Tuple<byte, byte, string>(7, 2, "Explosives"),
            new Tuple<byte, byte, string>(7, 3, "Devices"),
            new Tuple<byte, byte, string>(7, 4, "Jewelcrafting"),
            new Tuple<byte, byte, string>(7, 5, "Cloth"),
            new Tuple<byte, byte, string>(7, 6, "Leather"),
            new Tuple<byte, byte, string>(7, 7, "Metal & Stone"),
            new Tuple<byte, byte, string>(7, 8, "Meat"),
            new Tuple<byte, byte, string>(7, 9, "Herb"),
            new Tuple<byte, byte, string>(7, 10, "Elemental"),
            new Tuple<byte, byte, string>(7, 11, "Other"),
            new Tuple<byte, byte, string>(7, 12, "Enchanting"),
            new Tuple<byte, byte, string>(8, 0, "Generic(OBSOLETE)"),
            new Tuple<byte, byte, string>(9, 0, "Book"),
            new Tuple<byte, byte, string>(9, 1, "Leatherworking"),
            new Tuple<byte, byte, string>(9, 2, "Tailoring"),
            new Tuple<byte, byte, string>(9, 3, "Engineering"),
            new Tuple<byte, byte, string>(9, 4, "Blacksmithing"),
            new Tuple<byte, byte, string>(9, 5, "Cooking"),
            new Tuple<byte, byte, string>(9, 6, "Alchemy"),
            new Tuple<byte, byte, string>(9, 7, "First Aid"),
            new Tuple<byte, byte, string>(9, 8, "Enchanting"),
            new Tuple<byte, byte, string>(9, 9, "Fishing"),
            new Tuple<byte, byte, string>(9, 10, "Jewelcrafting"),
            new Tuple<byte, byte, string>(10, 0, "Money(OBSOLETE)"),
            new Tuple<byte, byte, string>(11, 0, "Quiver(OBSOLETE)"),
            new Tuple<byte, byte, string>(11, 1, "Quiver(OBSOLETE)"),
            new Tuple<byte, byte, string>(11, 2, "QuiverCan hold arrows"),
            new Tuple<byte, byte, string>(11, 3, "Ammo PouchCan hold bullets"),
            new Tuple<byte, byte, string>(12, 0, "Quest"),
            new Tuple<byte, byte, string>(13, 0, "Key"),
            new Tuple<byte, byte, string>(13, 1, "Lockpick"),
            new Tuple<byte, byte, string>(14, 0, "Permanent"),
            new Tuple<byte, byte, string>(15, 0, "Junk"),
            new Tuple<byte, byte, string>(15, 1, "Reagent"),
            new Tuple<byte, byte, string>(15, 2, "Pet"),
            new Tuple<byte, byte, string>(15, 3, "Holiday"),
            new Tuple<byte, byte, string>(15, 4, "Other"),
            new Tuple<byte, byte, string>(15, 5, "Mount"),
            new Tuple<byte, byte, string>(16, 1, "Warrior"),
            new Tuple<byte, byte, string>(16, 2, "Paladin"),
            new Tuple<byte, byte, string>(16, 3, "Hunter"),
            new Tuple<byte, byte, string>(16, 4, "Rogue"),
            new Tuple<byte, byte, string>(16, 5, "Priest"),
            new Tuple<byte, byte, string>(16, 6, "Death Knight"),
            new Tuple<byte, byte, string>(16, 7, "Shaman"),
            new Tuple<byte, byte, string>(16, 8, "Mage"),
            new Tuple<byte, byte, string>(16, 9, "Warlock"),
            new Tuple<byte, byte, string>(16, 11, "Druid"),
        };

        public static readonly Dictionary<byte, string> InventoryType = new Dictionary<byte, string>
        {
            {0, "Non equipable"     },
            {1, "Head"              },
            {2, "Neck"              },
            {3, "Shoulder"          },
            {4, "Shirt"             },
            {5, "Chest"             },
            {6, "Waist"             },
            {7, "Legs"              },
            {8, "Feet"              },
            {9, "Wrists"            },
            {10, "Hands"            },
            {11, "Finger"           },
            {12, "Trinket"          },
            {13, "Weapon"           },
            {14, "Shield"           },
            {15, "Ranged"           },
            {16, "Back"             },
            {17, "Two-Hand"         },
            {18, "Bag"              },
            {19, "Tabard"           },
            {20, "Robe"             },
            {21, "Main hand"        },
            {22, "Off hand"         },
            {23, "Holdable (Tome)"  },
            {24, "Ammo"             },
            {25, "Thrown"           },
            {26, "Ranged right"     },
            {27, "Quiver"           },
            {28, "Relic"            }
        };
    }
}
