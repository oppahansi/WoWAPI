using wowapi.Models.Db.Common;

namespace wowapi.Utilities
{
    public static class ItemUtils
    {
        public static float CalculateItemDps(ItemTemplateBase itemTemplate)
        {
            var speed = itemTemplate.Delay / 10000.0F;
            return (itemTemplate.DmgMin1 / speed + itemTemplate.DmgMax1 / speed) / 2;
        }
    }
}