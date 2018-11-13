using System;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models.Common;

namespace Entities.Models.Classic
{
    [Table("transports")]
    public class CTransports : TransportsBase
    {
        public uint Period { get; set; }
    }
}
