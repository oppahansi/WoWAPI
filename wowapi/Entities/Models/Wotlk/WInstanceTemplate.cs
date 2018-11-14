using System;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Wotlk
{
    public class WInstanceTemplate : InstanceTemplateBase
    {
        public string Script { get; set; }
        public byte AllowMount { get; set; }
    }
}
