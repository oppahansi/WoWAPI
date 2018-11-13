using System;
using Entities.Models.Common;

namespace Entities.Models.Wotlk
{
    public class WCreatureTemplate : CreatureTemplateBase
    {
        public uint DifficultyEntry1 { get; set; }
        public uint DifficultyEntry2 { get; set; }
        public uint DifficultyEntry3 { get; set; }
        public string IconName { get; set; }
        public short Exp { get; set; }
        public ushort Faction { get; set; }
        public uint Npcflag { get; set; }
        public sbyte Dmgschool { get; set; }
        public uint BaseAttackTime { get; set; }
        public uint RangeAttackTime { get; set; }
        public float BaseVariance { get; set; }
        public float RangeVariance { get; set; }
        public uint UnitFlags2 { get; set; }
        public byte Type { get; set; }
        public uint TypeFlags { get; set; }
        public uint Pickpocketloot { get; set; }
        public uint Skinloot { get; set; }
        public short Resistance1 { get; set; }
        public short Resistance2 { get; set; }
        public short Resistance3 { get; set; }
        public short Resistance4 { get; set; }
        public short Resistance5 { get; set; }
        public short Resistance6 { get; set; }
        public uint Spell1 { get; set; }
        public uint Spell2 { get; set; }
        public uint Spell3 { get; set; }
        public uint Spell4 { get; set; }
        public uint Spell5 { get; set; }
        public uint Spell6 { get; set; }
        public uint Spell7 { get; set; }
        public uint Spell8 { get; set; }
        public uint VehicleId { get; set; }
        public uint Mingold { get; set; }
        public uint Maxgold { get; set; }
        public float HoverHeight { get; set; }
        public float HealthModifier { get; set; }
        public float ManaModifier { get; set; }
        public float ArmorModifier { get; set; }
        public float DamageModifier { get; set; }
        public float ExperienceModifier { get; set; }
        public uint MovementId { get; set; }
        public byte RegenHealth { get; set; }
        public uint SpellSchoolImmuneMask { get; set; }
        public uint FlagsExtra { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
