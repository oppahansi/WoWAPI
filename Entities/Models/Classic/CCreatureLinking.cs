using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("creature_linking")]
    public class CCreatureLinking : IEntity
    {
        public uint Guid { get; set; }
        public uint MasterGuid { get; set; }
        public uint Flag { get; set; }
    }
}
