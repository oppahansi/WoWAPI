using wowapi.Entities.Models.Classic;
using wowapi.Enumerations;

namespace wowapi.Extensions
{
    public static class CreatureTemplateExtensions
    {
        public static bool IsObjectNull(this CCreatureTemplate creatureTemplatey)
        {
            return creatureTemplatey == null;
        }

        public static bool IsEmptyObject(this CCreatureTemplate creatureTemplate)
        {
            return creatureTemplate.Entry == 0;
        }

        public static bool IsVendor(this CCreatureTemplate creatureTemplate)
        {
            return (creatureTemplate.NpcFlags & (uint)CreatureEnums.NpcFlags.UNIT_NPC_FLAG_VENDOR) == (uint)CreatureEnums.NpcFlags.UNIT_NPC_FLAG_VENDOR;
        }
    }
}
