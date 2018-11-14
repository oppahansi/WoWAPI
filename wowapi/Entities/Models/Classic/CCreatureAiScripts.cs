using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Entities;

namespace wowapi.Entities.Models.Classic
{
    [Table("creature_ai_scripts")]
    public class CCreatureAiScripts : IEntity
    {
        [Key]
        public uint Id { get; set; }
        public uint CreatureId { get; set; }
        public byte EventType { get; set; }
        public int EventInversePhaseMask { get; set; }
        public uint EventChance { get; set; }
        public uint EventFlags { get; set; }
        public int EventParam1 { get; set; }
        public int EventParam2 { get; set; }
        public int EventParam3 { get; set; }
        public int EventParam4 { get; set; }
        public int EventParam5 { get; set; }
        public int EventParam6 { get; set; }
        public byte Action1Type { get; set; }
        public int Action1Param1 { get; set; }
        public int Action1Param2 { get; set; }
        public int Action1Param3 { get; set; }
        public byte Action2Type { get; set; }
        public int Action2Param1 { get; set; }
        public int Action2Param2 { get; set; }
        public int Action2Param3 { get; set; }
        public byte Action3Type { get; set; }
        public int Action3Param1 { get; set; }
        public int Action3Param2 { get; set; }
        public int Action3Param3 { get; set; }
        public string Comment { get; set; }
    }
}
