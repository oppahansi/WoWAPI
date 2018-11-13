using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("game_event_mail")]
    public class CGameEventMail : IEntity
    {
        [Key]
        public short Event { get; set; }
        [Key]
        public uint RaceMask { get; set; }
        [Key]
        public uint Quest { get; set; }
        public uint MailTemplateId { get; set; }
        public uint SenderEntry { get; set; }
    }
}
