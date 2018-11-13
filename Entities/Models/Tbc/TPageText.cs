using System;
using Entities.Models.Common;

namespace Entities.Models.Tbc
{
    public class TPageText : PageTextBase
    {
        public uint Entry { get; set; }
        public uint NextPage { get; set; }
    }
}
