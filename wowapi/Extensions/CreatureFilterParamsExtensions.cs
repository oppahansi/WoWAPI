using wowapi.Entities.Models.Search;

namespace wowapi.Extensions
{
    public static class CreatureFilterParamsExtensions
    {
        public static bool IsEmpty(this CreatureFilterParams creatureFilterParams)
        {
            return
            string.IsNullOrEmpty(creatureFilterParams.Name) &&
            string.IsNullOrEmpty(creatureFilterParams.SubName) &&
            creatureFilterParams.MinLevel == 0 &&
            creatureFilterParams.MaxLevel == 0 &&
            creatureFilterParams.Family == 0 && 
            creatureFilterParams.Type == 0 &&
            creatureFilterParams.NpcFlags == 0 &&
            creatureFilterParams.ExtraFlags == 0 &&
            creatureFilterParams.MechanicImmuneMask == 0 &&
            creatureFilterParams.Civilian == 2;
        }
    }
}