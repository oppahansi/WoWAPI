using System;
namespace Entities.Models.Common
{
    public class SpellBonusDataBase : IEntity
    {
        public float DirectBonus { get; set; }
        public float DotBonus { get; set; }
        public float ApBonus { get; set; }
        public float ApDotBonus { get; set; }
        public string Comments { get; set; }
    }
}
