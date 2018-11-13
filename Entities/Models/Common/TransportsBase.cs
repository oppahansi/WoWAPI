using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models.Common
{
    public class TransportsBase : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        public string Name { get; set; }
    }
}
