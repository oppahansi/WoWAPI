using System;
namespace wowapi.Entities.Models.Common
{
    public class PointsOfInterestBase : IEntity
    {
        public uint Icon { get; set; }
        public uint Flags { get; set; }
    }
}
