using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("instance_dungeon_encounters")]
    public class CInstanceDungeonEncounters : IEntity
    {
        [Key]
        public uint Id { get; set; }
        public uint MapId { get; set; }
        public uint Difficulty { get; set; }
        public uint EncounterData { get; set; }
        public uint EncounterIndex { get; set; }
        public string EncounterName { get; set; }
        public string EncounterName2 { get; set; }
        public string EncounterName3 { get; set; }
        public string EncounterName4 { get; set; }
        public string EncounterName5 { get; set; }
        public string EncounterName6 { get; set; }
        public string EncounterName7 { get; set; }
        public string EncounterName8 { get; set; }
        public string EncounterName9 { get; set; }
        public string EncounterName10 { get; set; }
        public string EncounterName11 { get; set; }
        public string EncounterName12 { get; set; }
        public string EncounterName13 { get; set; }
        public string EncounterName14 { get; set; }
        public string EncounterName15 { get; set; }
        public string EncounterName16 { get; set; }
        public uint NameLangFlags { get; set; }
        public uint SpellIconId { get; set; }
    }
}
