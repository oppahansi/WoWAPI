using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("game_event_mail")]
    public class CGameEventMail
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
