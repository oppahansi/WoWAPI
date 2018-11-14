using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Entities;

namespace wowapi.Entities.Models.Classic
{
    [Table("creature_linking_template")]
    public class CCreatureLinkingTemplate :IEntity
    {
        [Key]
        public uint Entry { get; set; }
        [Key]
        public ushort Map { get; set; }
        public uint MasterEntry { get; set; }
        public uint Flag { get; set; }
        public uint SearchRange { get; set; }
    }
}
