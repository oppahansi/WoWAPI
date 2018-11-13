using System;
using Entities.Models.Common;

namespace Entities.Models.Wotlk
{
    public class WCreatureModelInfo : CreatureModelInfoBase
    {
        public uint DisplayId { get; set; }
        public uint DisplayIdOtherGender { get; set; }
    }
}
