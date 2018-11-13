using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("auctions")]
    public class CAuction : IEntity
    {
        [Key]
        public uint Id { get; set; }
        public uint Houseid { get; set; }
        public uint Itemguid { get; set; }
        public uint ItemTemplate { get; set; }
        public uint ItemCount { get; set; }
        public int ItemRandompropertyid { get; set; }
        public uint Itemowner { get; set; }
        public int Buyoutprice { get; set; }
        public ulong Time { get; set; }
        public uint Buyguid { get; set; }
        public int Lastbid { get; set; }
        public int Startbid { get; set; }
        public int Deposit { get; set; }
    }
}
