namespace wowapi.Models.Db.Common
{
    public class InstanceEncountersBase
    {
        public uint Entry { get; set; }
        public byte CreditType { get; set; }
        public uint CreditEntry { get; set; }
        public ushort LastEncounterDungeon { get; set; }
    }
}
