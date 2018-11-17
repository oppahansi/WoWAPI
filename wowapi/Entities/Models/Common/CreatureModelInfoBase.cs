namespace wowapi.Entities.Models.Common
{
    public class CreatureModelInfoBase : IEntity
    {
        public float BoundingRadius { get; set; }
        public float CombatReach { get; set; }
        public byte Gender { get; set; }
    }
}
