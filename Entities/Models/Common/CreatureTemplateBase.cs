using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models.Common
{
    public class CreatureTemplateBase : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        public string Name { get; set; }
        public string SubName { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
        public uint ModelId1 { get; set; }
        public uint ModelId2 { get; set; }
        public uint ModelId3 { get; set; }
        public uint ModelId4 { get; set; }
        public float Scale { get; set; }
        public sbyte Family { get; set; }
        public byte InhabitType { get; set; }
        public byte RacialLeader { get; set; }
        public uint UnitFlags { get; set; }
        public uint DynamicFlags { get; set; }
        public float SpeedWalk { get; set; }
        public float SpeedRun { get; set; }
        public byte UnitClass { get; set; }
        public byte Rank { get; set; }
        public uint LootId { get; set; }
        public uint KillCredit1 { get; set; }
        public uint KillCredit2 { get; set; }
        public uint MechanicImmuneMask { get; set; }
        public uint PetSpellDataId { get; set; }
        public byte MovementType { get; set; }
        public sbyte TrainerType { get; set; }
        public uint TrainerSpell { get; set; }
        public byte TrainerClass { get; set; }
        public byte TrainerRace { get; set; }
        public uint GossipMenuId { get; set; }
        public string Ainame { get; set; }
        public string ScriptName { get; set; }
    }
}
