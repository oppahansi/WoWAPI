using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Classic
{
    [Table("transports")]
    public class CTransports : TransportsBase
    {
        public uint Period { get; set; }
    }
}
