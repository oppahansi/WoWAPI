using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("spam_records")]
    public class CSpamRecords : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Record { get; set; }
    }
}
