using System;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Tbc
{
    public class TPageText : PageTextBase
    {
        public uint Entry { get; set; }
        public uint NextPage { get; set; }
    }
}
