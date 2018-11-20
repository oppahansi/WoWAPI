using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Wotlk
{
    public class WInstanceTemplate : InstanceTemplateBase
    {
        public string Script { get; set; }
        public byte AllowMount { get; set; }
    }
}
