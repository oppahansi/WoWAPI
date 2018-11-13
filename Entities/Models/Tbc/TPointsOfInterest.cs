using System;
using Entities.Models.Common;

namespace Entities.Models.Tbc
{
    public class TPointsOfInterest : PointsOfInterestBase
    {
        public uint Entry { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public uint Data { get; set; }
        public string IconName { get; set; }
    }
}
