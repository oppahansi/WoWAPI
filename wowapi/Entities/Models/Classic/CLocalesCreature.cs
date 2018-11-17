﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Classic
{
    [Table("locales_creature")]
    public class CLocalesCreature : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        public string NameLoc1 { get; set; }
        public string NameLoc2 { get; set; }
        public string NameLoc3 { get; set; }
        public string NameLoc4 { get; set; }
        public string NameLoc5 { get; set; }
        public string NameLoc6 { get; set; }
        public string NameLoc7 { get; set; }
        public string NameLoc8 { get; set; }
        public string SubnameLoc1 { get; set; }
        public string SubnameLoc2 { get; set; }
        public string SubnameLoc3 { get; set; }
        public string SubnameLoc4 { get; set; }
        public string SubnameLoc5 { get; set; }
        public string SubnameLoc6 { get; set; }
        public string SubnameLoc7 { get; set; }
        public string SubnameLoc8 { get; set; }
    }
}
