using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Tbc
{
    public class TGameobjectTemplate : GameObjectTemplateBase
    {
        public string IconName { get; set; }
        public string CastBarCaption { get; set; }
        public ushort Faction { get; set; }
        public uint Flags { get; set; }
        public uint ExtraFlags { get; set; }
        public uint Data1 { get; set; }
        public uint Data6 { get; set; }
        public uint CustomData1 { get; set; }
        public uint Mingold { get; set; }
        public uint Maxgold { get; set; }
    }
}
