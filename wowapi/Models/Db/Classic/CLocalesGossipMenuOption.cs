using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("locales_gossip_menu_option")]
    public class CLocalesGossipMenuOption
    {
        [Key]
        public ushort MenuId { get; set; }
        [Key]
        public ushort Id { get; set; }
        public string OptionTextLoc1 { get; set; }
        public string OptionTextLoc2 { get; set; }
        public string OptionTextLoc3 { get; set; }
        public string OptionTextLoc4 { get; set; }
        public string OptionTextLoc5 { get; set; }
        public string OptionTextLoc6 { get; set; }
        public string OptionTextLoc7 { get; set; }
        public string OptionTextLoc8 { get; set; }
        public string BoxTextLoc1 { get; set; }
        public string BoxTextLoc2 { get; set; }
        public string BoxTextLoc3 { get; set; }
        public string BoxTextLoc4 { get; set; }
        public string BoxTextLoc5 { get; set; }
        public string BoxTextLoc6 { get; set; }
        public string BoxTextLoc7 { get; set; }
        public string BoxTextLoc8 { get; set; }
    }
}
