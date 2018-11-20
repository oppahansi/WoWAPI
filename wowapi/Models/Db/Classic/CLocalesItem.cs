﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("locales_item")]
    public class CLocalesItem
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
        public string DescriptionLoc1 { get; set; }
        public string DescriptionLoc2 { get; set; }
        public string DescriptionLoc3 { get; set; }
        public string DescriptionLoc4 { get; set; }
        public string DescriptionLoc5 { get; set; }
        public string DescriptionLoc6 { get; set; }
        public string DescriptionLoc7 { get; set; }
        public string DescriptionLoc8 { get; set; }
    }
}
