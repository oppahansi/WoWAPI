using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Classic
{
    [Table("game_event_creature_data")]
    public class CGameEventCreatureData : IEntity
    {
        [Key]
        public uint Guid { get; set; }
        public uint EntryId { get; set; }
        public uint Modelid { get; set; }
        public uint EquipmentId { get; set; }
        public uint SpellStart { get; set; }
        public uint SpellEnd { get; set; }
        [Key]
        public ushort Event { get; set; }
    }
}
