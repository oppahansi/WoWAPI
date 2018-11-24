using System.Collections.Generic;
using wowapi.Models.Db.Classic;

namespace wowapi.Extensions
{
    public static class LootTemplateExtensions
    {
        public static bool IsObjectNull(this CCreatureLootTemplate creatureLootTemplate)
        {
            return creatureLootTemplate == null;
        }

        public static bool IsEmptyObject(this CCreatureLootTemplate creatureLootTemplate)
        {
            return creatureLootTemplate.Entry == 0;
        }

        public static bool IsObjectNull(this CReferenceLootTemplate creatureLootTemplate)
        {
            return creatureLootTemplate == null;
        }

        public static bool IsEmptyObject(this CReferenceLootTemplate creatureLootTemplate)
        {
            return creatureLootTemplate.Entry == 0;
        }
    }
}