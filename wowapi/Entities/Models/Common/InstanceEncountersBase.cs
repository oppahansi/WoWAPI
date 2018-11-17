namespace wowapi.Entities.Models.Common
{
    public class InstanceEncountersBase : IEntity
    {
        public uint Entry { get; set; }
        public byte CreditType { get; set; }
        public uint CreditEntry { get; set; }
        public ushort LastEncounterDungeon { get; set; }
    }
}
