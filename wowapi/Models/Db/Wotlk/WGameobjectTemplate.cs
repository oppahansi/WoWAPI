using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Wotlk
{
    public class WGameobjectTemplate : GameObjectTemplateBase
    {
        public string IconName { get; set; }
        public string CastBarCaption { get; set; }
        public string Unk1 { get; set; }
        public int Data1 { get; set; }
        public int Data6 { get; set; }
        public string Ainame { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
