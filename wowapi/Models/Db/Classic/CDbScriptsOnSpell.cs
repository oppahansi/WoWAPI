using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("dbscripts_on_spell")]
    public class CDbScriptsOnSpell
    {
        public uint Id { get; set; }
        public uint Delay { get; set; }
        public uint Command { get; set; }
        public uint DataLong { get; set; }
        public uint DataLong2 { get; set; }
        public uint DataLong3 { get; set; }
        public uint BuddyEntry { get; set; }
        public uint SearchRadius { get; set; }
        public byte DataFlags { get; set; }
        public uint DataInt { get; set; }
        public uint DataInt2 { get; set; }
        public uint DataInt3 { get; set; }
        public uint DataInt4 { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float O { get; set; }
        public string Comments { get; set; }

    }
}
