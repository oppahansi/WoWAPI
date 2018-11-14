using System;
using System.ComponentModel.DataAnnotations;

namespace wowapi.Entities.Models.Common
{
    public class SpellAreaBase : IEntity
    {
        [Key]
        public uint Spell { get; set; }
        [Key]
        public uint Area { get; set; }
        [Key]
        public uint QuestStart { get; set; }
        public uint QuestEnd { get; set; }
        [Key]
        public int AuraSpell { get; set; }
        [Key]
        public uint Racemask { get; set; }
        [Key]
        public byte Gender { get; set; }
        public byte Autocast { get; set; }
    }
}
