using System;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models.Common;

namespace Entities.Models.Classic
{
    [Table("command")]
    public class CCommand : CommandBase
    {
        public byte Security { get; set; }
    }
}
