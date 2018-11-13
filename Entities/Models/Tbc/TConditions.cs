using System;
using Entities.Models.Common;

namespace Entities.Models.Tbc
{
    public class TConditions : IEntity
    {
        public uint ConditionEntry { get; set; }
        public sbyte Type { get; set; }
        public uint Value1 { get; set; }
        public uint Value2 { get; set; }
        public string Comments { get; set; }
    }
}
