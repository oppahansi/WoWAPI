using wowapi.Entities.Models.Classic;

namespace wowapi.Entities.Extensions
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
    }
}
