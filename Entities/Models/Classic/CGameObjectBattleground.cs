using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("gameobject_battleground")]
    public class CGameObjectBattleground : IEntity
    {
        [Key]
        public uint Guid { get; set; }
        public byte Event1 { get; set; }
        public byte Event2 { get; set; }
    }
}
