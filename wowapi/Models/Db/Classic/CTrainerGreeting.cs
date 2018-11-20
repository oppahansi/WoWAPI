using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("trainer_greeting")]
    public class CTrainerGreeting
    {
        [Key]
        public uint Entry { get; set; }
        public string Text { get; set; }
    }
}
