using System;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models.Common;

namespace Entities.Models.Classic
{
    [Table("instance_template")]
    public class CInstanceTemplate : InstanceTemplateBase
    {
        public byte LevelMin { get; set; }
        public byte LevelMax { get; set; }
        public byte MaxPlayers { get; set; }
        public uint ResetDelay { get; set; }
        public ushort GhostEntranceMap { get; set; }
        public float GhostEntranceX { get; set; }
        public float GhostEntranceY { get; set; }
        public string ScriptName { get; set; }
        public byte MountAllowed { get; set; }
    }
}
