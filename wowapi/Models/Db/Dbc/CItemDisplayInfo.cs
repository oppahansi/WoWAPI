using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Dbc
{
    [Table("dbc_ItemDisplayInfo")]
    public class CItemDisplayInfo
    {
        [Key]
        public int Id { get; set; }
        [Column("inventoryIcon1")]
        public string Icon { get; set; }
        [Column("inventoryIcon2")]
        public string Icon2 { get; set; }
    }
}