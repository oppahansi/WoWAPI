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