using System.Linq;
using wowapi.Enumerations;
using wowapi.Models.Db.Classic;
using wowapi.Models.Search;

namespace wowapi.Extensions
{
    public static class PaginatedListExtensions
    {
        public static object CreateResultObject(this PaginatedList<CCreatureTemplate> paginatedList)
        {
            return paginatedList.Select(x => new
                    {
                        Id = x.Entry,
                        Name = x.Name,
                        SubName = x.SubName,
                        MinLevel = x.MinLevel,
                        MaxLevel = x.MaxLevel,
                        CreatureType = x.CreatureType,
                        Rank = x.Rank
                    });
        }

        public static object CreateResultObject(this PaginatedList<CItemTemplate> paginatedList, byte itemClass)
        {
            switch (itemClass)
            {   case (byte)ItemEnums.ItemClasses.CONTAINER:
                    return paginatedList.Select(x => new
                    {
                        Id = x.Entry,
                        Name = x.Name,
                        Class = x.Class,
                        SubClass = x.Subclass,
                        Quality = x.Quality,
                        ReqLevel = x.RequiredLevel,
                        ItemLevel = x.ItemLevel,
                        ContainerSlots = x.ContainerSlots
                    });
                case (byte)ItemEnums.ItemClasses.WEAPON:
                    return paginatedList.Select(x => new
                    {
                        Id = x.Entry,
                        Name = x.Name,
                        Class = x.Class,
                        SubClass = x.Subclass,
                        Quality = x.Quality,
                        ReqLevel = x.RequiredLevel,
                        ItemLevel = x.ItemLevel,
                        Dps = x.CalculateItemDps(),
                        Speed = x.Delay / 1000.0F
                    });
                case (byte)ItemEnums.ItemClasses.ARMOR:
                    return paginatedList.Select(x => new
                    {
                        Id = x.Entry,
                        Name = x.Name,
                        Class = x.Class,
                        SubClass = x.Subclass,
                        Quality = x.Quality,
                        ReqLevel = x.RequiredLevel,
                        ItemLevel = x.ItemLevel,
                        Armor = x.Armor,
                        Slot = x.InventoryType
                    });
                case (byte)ItemEnums.ItemClasses.CONSUMEABLE:
                case (byte)ItemEnums.ItemClasses.REAGENT:
                case (byte)ItemEnums.ItemClasses.PROJECTILE:
                case (byte)ItemEnums.ItemClasses.TRADE_GOODS:
                case (byte)ItemEnums.ItemClasses.GENERIC:
                case (byte)ItemEnums.ItemClasses.RECIPE:
                case (byte)ItemEnums.ItemClasses.MONEY:
                case (byte)ItemEnums.ItemClasses.QUIVER:
                case (byte)ItemEnums.ItemClasses.QUEST:
                case (byte)ItemEnums.ItemClasses.KEY:
                case (byte)ItemEnums.ItemClasses.PERMANENT:
                case (byte)ItemEnums.ItemClasses.MISC:
                case (byte)ItemEnums.ItemClasses.GLYPH:
                default:
                    return paginatedList.Select(x => new
                    {
                        Id = x.Entry,
                        Name = x.Name,
                        Class = x.Class,
                        SubClass = x.Subclass,
                        Quality = x.Quality,
                        ReqLevel = x.RequiredLevel,
                        ItemLevel = x.ItemLevel
                    });
            }
        }
    }
}