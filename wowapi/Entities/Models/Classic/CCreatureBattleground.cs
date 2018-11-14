using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Entities;

namespace wowapi.Entities.Models.Classic
{
    [Table("creature_battleground")]
    public class CCreatureBattleground : IEntity
    {
        [Key]
        public uint Guid { get; set; }
        public byte Event1 { get; set; }
        public byte Event2 { get; set; }
    }
}
