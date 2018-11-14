using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Classic
{
    [Table("points_of_interest")]
    public class CPointsOfInterest : PointsOfInterestBase
    {
        [Key]
        public uint Entry { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public uint Data { get; set; }
        public string IconName { get; set; }
    }
}
