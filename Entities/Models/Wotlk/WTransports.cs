using System;
using Entities.Models.Common;

namespace Entities.Models.Wotlk
{
    public class WTransports : TransportsBase
    {
        public uint Guid { get; set; }
        public string ScriptName { get; set; }
    }
}
