using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Tbc
{
    public class TPageText : PageTextBase
    {
        public uint Entry { get; set; }
        public uint NextPage { get; set; }
    }
}
