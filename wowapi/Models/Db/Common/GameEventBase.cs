namespace wowapi.Models.Db.Common
{
    public class GameEventBase
    {
        public ulong Occurence { get; set; }
        public ulong Length { get; set; }
        public uint Holiday { get; set; }
        public string Description { get; set; }
    }
}
