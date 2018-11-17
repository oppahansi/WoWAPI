using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Classic
{
    [Table("questgiver_greeting")]
    public class CQuestGiverGreeting : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        [Key]
        public uint Type { get; set; }
        public string Text { get; set; }
        public uint EmoteId { get; set; }
        public uint EmoteDelay { get; set; }
    }
}
