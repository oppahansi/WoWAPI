using System;
namespace wowapi.Entities.Models.Common
{
    public class GameEventBase : IEntity
    {
        public ulong Occurence { get; set; }
        public ulong Length { get; set; }
        public uint Holiday { get; set; }
        public string Description { get; set; }
    }
}
