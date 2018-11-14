using System;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Classic
{
    [Table("transports")]
    public class CTransports : TransportsBase
    {
        public uint Period { get; set; }
    }
}
