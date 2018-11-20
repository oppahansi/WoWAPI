using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Wotlk
{
    public class WCreature : CreatureBase
    {
        public ushort ZoneId { get; set; }
        public ushort AreaId { get; set; }
        public byte SpawnMask { get; set; }
        public uint PhaseMask { get; set; }
        public sbyte EquipmentId { get; set; }
        public uint Spawntimesecs { get; set; }
        public uint Npcflag { get; set; }
        public uint UnitFlags { get; set; }
        public uint Dynamicflags { get; set; }
        public string ScriptName { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
