using wowapi.Entities.Models.Classic;
using wowapi.Entities.Models.Tbc;
using wowapi.Entities.Models.Wotlk;

namespace wowapi.Entities.ModelsPrepared
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
        public uint Immunities { get; }
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
            Immunities = creatureTemplate.MechanicImmuneMask;
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
            Immunities = creatureTemplate.MechanicImmuneMask;
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
            Immunities = creatureTemplate.MechanicImmuneMask;
            ResistanceHoly = creatureTemplate.Resistance1;
            ResistanceFire = creatureTemplate.Resistance2;
            ResistanceNature = creatureTemplate.Resistance3;
            ResistanceFrost = creatureTemplate.Resistance4;
            ResistanceShadow = creatureTemplate.Resistance5;
            ResistanceArcane = creatureTemplate.Resistance6;
        }
    }
}