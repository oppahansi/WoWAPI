using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Common
{
    [Table("pool_template")]
    public class PoolTemplateBase : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        public uint MaxLimit { get; set; }
        public string Description { get; set; }
    }
}
