using System;
using Entities.Models.Common;

namespace Entities.Models.Wotlk
{
    public class WInstanceTemplate : InstanceTemplateBase
    {
        public string Script { get; set; }
        public byte AllowMount { get; set; }
    }
}
