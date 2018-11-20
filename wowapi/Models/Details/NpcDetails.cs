using wowapi.Models.Db.Classic;
using wowapi.Models.Db.Tbc;
using wowapi.Models.Db.Wotlk;

namespace wowapi.Models.Details
{
    public class NpcDetails : NpcDetailsBase 
    {
        public string Ainame { get; }
        public string ScriptName { get; }
        public uint MinLootGold { get; }
        public uint MaxLootGold { get; }
        public uint LootId { get; set; }
        public uint PickpocketLootId { get; }
        public uint SkinningLootId { get; }
        public uint VendorTemplateId { get; }
        public uint NpcFlags { get; }
        public uint ExtraFlags { get; }
        public uint MechanicImmunities { get; }
        public uint SchoolImmunities { get; }
        public short ResistanceHoly { get; }
        public short ResistanceFire { get; }
        public short ResistanceNature { get; }
        public short ResistanceFrost { get; }
        public short ResistanceShadow { get; }
        public short ResistanceArcane { get; }

        public NpcDetails (CCreatureTemplate creatureTemplate) : base (creatureTemplate)
        {
            Ainame = creatureTemplate.Ainame;
            ScriptName = creatureTemplate.ScriptName;
            MinLootGold = creatureTemplate.MinLootGold;
            MaxLootGold = creatureTemplate.MaxLootGold;
            LootId = creatureTemplate.LootId;
            PickpocketLootId = creatureTemplate.PickpocketLootId;
            SkinningLootId = creatureTemplate.SkinningLootId;
            VendorTemplateId = creatureTemplate.VendorTemplateId;
            ExtraFlags = creatureTemplate.ExtraFlags;
            NpcFlags = creatureTemplate.NpcFlags;
            MechanicImmunities = creatureTemplate.MechanicImmuneMask;
            SchoolImmunities = creatureTemplate.SchoolImmuneMask;
            ResistanceHoly = creatureTemplate.ResistanceHoly;
            ResistanceFire = creatureTemplate.ResistanceFire;
            ResistanceNature = creatureTemplate.ResistanceNature;
            ResistanceFrost = creatureTemplate.ResistanceFrost;
            ResistanceShadow = creatureTemplate.ResistanceShadow;
            ResistanceArcane = creatureTemplate.ResistanceArcane;
        }

        public NpcDetails (TCreatureTemplate creatureTemplate) : base (creatureTemplate)
        {
            Ainame = creatureTemplate.Ainame;
            ScriptName = creatureTemplate.ScriptName;
            MinLootGold = creatureTemplate.MinLootGold;
            MaxLootGold = creatureTemplate.MaxLootGold;
            LootId = creatureTemplate.LootId;
            PickpocketLootId = creatureTemplate.PickpocketLootId;
            SkinningLootId = creatureTemplate.SkinningLootId;
            VendorTemplateId = creatureTemplate.VendorTemplateId;
            ExtraFlags = creatureTemplate.ExtraFlags;
            NpcFlags = creatureTemplate.NpcFlags;
            MechanicImmunities = creatureTemplate.MechanicImmuneMask;
            SchoolImmunities = creatureTemplate.SchoolImmuneMask;
            ResistanceHoly = creatureTemplate.ResistanceHoly;
            ResistanceFire = creatureTemplate.ResistanceFire;
            ResistanceNature = creatureTemplate.ResistanceNature;
            ResistanceFrost = creatureTemplate.ResistanceFrost;
            ResistanceShadow = creatureTemplate.ResistanceShadow;
            ResistanceArcane = creatureTemplate.ResistanceArcane;
        }

        public NpcDetails(WCreatureTemplate creatureTemplate) : base(creatureTemplate)
        {
            Ainame = creatureTemplate.Ainame;
            ScriptName = creatureTemplate.ScriptName;
            MinLootGold = creatureTemplate.Mingold;
            MaxLootGold = creatureTemplate.Maxgold;
            LootId = creatureTemplate.LootId;
            PickpocketLootId = creatureTemplate.Pickpocketloot;
            SkinningLootId = creatureTemplate.Skinloot;
            VendorTemplateId = creatureTemplate.Entry;
            ExtraFlags = creatureTemplate.FlagsExtra;
            NpcFlags = creatureTemplate.Npcflag;
            MechanicImmunities = creatureTemplate.MechanicImmuneMask;
            SchoolImmunities = creatureTemplate.SpellSchoolImmuneMask;
            ResistanceHoly = creatureTemplate.Resistance1;
            ResistanceFire = creatureTemplate.Resistance2;
            ResistanceNature = creatureTemplate.Resistance3;
            ResistanceFrost = creatureTemplate.Resistance4;
            ResistanceShadow = creatureTemplate.Resistance5;
            ResistanceArcane = creatureTemplate.Resistance6;
        }
    }
}