using System;
using Entities.ModelsPrepared;

namespace Entities.Extensions
{
    public static class NpcDetailsExtensions
    {
        public static bool IsObjectNull(this NpcDetails npcDetails)
        {
            return npcDetails == null;
        }

        public static bool IsEmptyObject(this NpcDetails npcDetails)
        {
            return npcDetails.Entry == 0;
        }
    }
}
