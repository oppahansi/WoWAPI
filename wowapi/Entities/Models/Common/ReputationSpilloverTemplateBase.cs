using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Common
{
    [Table("reputation_spillover_template")]
    public class ReputationSpilloverTemplateBase : IEntity
    {
        [Key]
        public ushort Faction { get; set; }
        public ushort Faction1 { get; set; }
        public float Rate1 { get; set; }
        public byte Rank1 { get; set; }
        public ushort Faction2 { get; set; }
        public float Rate2 { get; set; }
        public byte Rank2 { get; set; }
        public ushort Faction3 { get; set; }
        public float Rate3 { get; set; }
        public byte Rank3 { get; set; }
        public ushort Faction4 { get; set; }
        public float Rate4 { get; set; }
        public byte Rank4 { get; set; }
    }
}
