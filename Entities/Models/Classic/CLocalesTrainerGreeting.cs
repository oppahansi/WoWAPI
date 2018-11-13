using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("locales_trainer_greeting")]
    public class CLocalesTrainerGreeting : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        public string TextLoc1 { get; set; }
        public string TextLoc2 { get; set; }
        public string TextLoc3 { get; set; }
        public string TextLoc4 { get; set; }
        public string TextLoc5 { get; set; }
        public string TextLoc6 { get; set; }
        public string TextLoc7 { get; set; }
        public string TextLoc8 { get; set; }
    }
}
