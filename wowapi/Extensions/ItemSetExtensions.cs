using System.Collections.Generic;
using wowapi.Models.Db.Dbc;

namespace wowapi.Extensions
{
    public static class ItemSetExtensions
    {
        public static bool IsObjectNull(this CItemSet itemSet)
        {
            return itemSet == null;
        }

        public static bool IsEmptyObject(this CItemSet itemSet)
        {
            return itemSet.Id == 0;
        }

        public static IEnumerable<uint> GetItemEntries(this CItemSet itemSet)
        {
            List<uint> entries = new List<uint>();

            if (itemSet.Item1 != 0)
                entries.Add((uint)itemSet.Item1);
            
            if (itemSet.Item2 != 0)
                entries.Add((uint)itemSet.Item2);
            
            if (itemSet.Item3 != 0)
                entries.Add((uint)itemSet.Item3);
            
            if (itemSet.Item5 != 0)
                entries.Add((uint)itemSet.Item4);
            
            if (itemSet.Item5 != 0)
                entries.Add((uint)itemSet.Item5);

            if (itemSet.Item6 != 0)
                entries.Add((uint)itemSet.Item6);
            
            if (itemSet.Item7 != 0)
                entries.Add((uint)itemSet.Item7);
            
            if (itemSet.Item8 != 0)
                entries.Add((uint)itemSet.Item8);
            
            if (itemSet.Item9 != 0)
                entries.Add((uint)itemSet.Item9);
            
            if (itemSet.Item10 != 0)
                entries.Add((uint)itemSet.Item10);

            return entries;
        }

        public static object CreateResponeObject(this CItemSet itemSet)
        {
            return new
            {
                Id = itemSet.Id,
                Name = itemSet.Name,
                Items = new
                {
                    itemSet.Item1,
                    itemSet.Item2,
                    itemSet.Item3,
                    itemSet.Item4,
                    itemSet.Item5,
                    itemSet.Item6,
                    itemSet.Item7,
                    itemSet.Item8,
                    itemSet.Item9,
                    itemSet.Item10
                },
                SetSpells = new
                {
                    itemSet.SetSpell1,
                    itemSet.SetSpell2,
                    itemSet.SetSpell3,
                    itemSet.SetSpell4,
                    itemSet.SetSpell5,
                    itemSet.SetSpell6,
                    itemSet.SetSpell7,
                    itemSet.SetSpell8,
                },
                Thresholds = new
                {
                    itemSet.SetThreshold1,
                    itemSet.SetThreshold2,
                    itemSet.SetThreshold3,
                    itemSet.SetThreshold4,
                    itemSet.SetThreshold5,
                    itemSet.SetThreshold6,
                    itemSet.SetThreshold7,
                    itemSet.SetThreshold8,
                } 
            };
        }
    }
}