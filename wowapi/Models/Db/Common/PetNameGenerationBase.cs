using System.ComponentModel.DataAnnotations;

namespace wowapi.Models.Db.Common
{
    public class PetNameGenerationBase
    {
        [Key]
        public uint Id { get; set; }
        public string Word { get; set; }
        public uint Entry { get; set; }
    }
}
