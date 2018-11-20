using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("creature_equip_template_raw")]
    public class CCreatureEquipTemplateRaw
    {
        [Key]
        public uint Entry { get; set; }
        public uint Equipmodel1 { get; set; }
        public uint Equipmodel2 { get; set; }
        public uint Equipmodel3 { get; set; }
        public uint Equipinfo1 { get; set; }
        public uint Equipinfo2 { get; set; }
        public uint Equipinfo3 { get; set; }
        public int Equipslot1 { get; set; }
        public int Equipslot2 { get; set; }
        public int Equipslot3 { get; set; }
    }
}
