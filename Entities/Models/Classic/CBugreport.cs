using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("")]
    public class CBugreport : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
    }
}
