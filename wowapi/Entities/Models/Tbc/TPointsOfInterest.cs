using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Tbc
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
