using Microsoft.EntityFrameworkCore;
using wowapi.Models.Db.Classic;

namespace wowapi.Contexts
{
    public class CRepositoryContext : DbContext
    {
        public CRepositoryContext(DbContextOptions options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CReferenceLootTemplate>().HasKey(x => new { x.Entry, x.Item });
            modelBuilder.Entity<CCreatureLootTemplate>().HasKey(x => new { x.Entry, x.Item });
            modelBuilder.Entity<CNpcVendor>().HasKey(x => new { x.Entry, x.Item });
            modelBuilder.Entity<CNpcVendorTemplate>().HasKey(x => new { x.Entry, x.Item });
            modelBuilder.Entity<CPickPocketingLootTemplate>().HasKey(x => new { x.Entry, x.Item });
        }

       /* public DbSet<AreatriggerInvolvedrelationBase> AreatriggerInvolvedrelations { get; set; }
        public DbSet<AreatriggerTavernBase> AreatriggerTaverns { get; set; }
        public DbSet<CAreatriggerTeleport> AreatriggerTeleports { get; set; }
        public DbSet<CAuction> Auctions { get; set; }
        public DbSet<CBattlegroundEvents> BattlegroundEvents { get; set; }
        public DbSet<BattlegroundTemplateBase> BattlegroundTemplates { get; set; }
        public DbSet<BattleMasterEntryBase> BattlemasterEntries { get; set; }
        public DbSet<CBugreport> Bugreports { get; set; }
        public DbSet<CCommand> Commands { get; set; }
        public DbSet<CConditions> Conditionss { get; set; }*/
        /* public DbSet<CCreature> Creatures { get; set; }/*
        public DbSet<CCreatureAiScripts> CreatureAiScripts { get; set; }
        public DbSet<CCreatureAiSummons> CreatureAiSummons { get; set; }
        public DbSet<CCreatureAiTexts> CreatureAiTexts { get; set; }
        public DbSet<CCreatureAddon> CreatureAddons { get; set; }
        public DbSet<CCreatureBattleground> CreatureBattlegrounds { get; set; }
        public DbSet<CCreatureConditionalSpawn> CreatureConditionalSpawns { get; set; }
        public DbSet<CCreatureEquipTemplate> CreatureEquipTemplates { get; set; }
        public DbSet<CCreatureEquipTemplateRaw> CreatureEquipTemplateRaws { get; set; }
        public DbSet<CCreatureInvolvedrelation> CreatureInvolvedrelations { get; set; }
        public DbSet<CCreatureLinking> CreatureLinkings { get; set; }
        public DbSet<CCreatureLinkingTemplate> CreatureLinkingTemplates { get; set; }*/
        public DbSet<CCreatureLootTemplate> CreatureLootTemplates { get; set; }
        /*public DbSet<CCreatureModelInfo> CreatureModelInfos { get; set; }
        public DbSet<CCreatureMovement> CreatureMovements { get; set; }
        public DbSet<CCreatureMovementTemplate> CreatureMovementTemplates { get; set; }
        public DbSet<CreatureOnkillReputationBase> CreatureOnkillReputations { get; set; }
        public DbSet<CCreatureQuestrelation> CreatureQuestrelations { get; set; }*/
        public DbSet<CCreatureTemplate> CreatureTemplates { get; set; }
        /*public DbSet<CCreatureTemplateAddon> CreatureTemplateAddons { get; set; }
        public DbSet<CCreatureTemplateClassLevelStats> CreatureTemplateClasslevelStats { get; set; }
        public DbSet<CCreatureTemplateSpells> CreatureTemplateSpells { get; set; }
        public DbSet<CCustomTexts> CustomTexts { get; set; }
        public DbSet<CDbScriptRandomTemplates> DbScriptRandomTemplates { get; set; }
        public DbSet<CDbScriptsOnCreatureDeath> DbScriptsOnCreatureDeaths { get; set; }
        public DbSet<CDbScriptsOnCreatureMovement> DbScriptsOnCreatureMovements { get; set; }
        public DbSet<CDbScriptsOnEvent> DbScriptsOnEvents { get; set; }
        public DbSet<CDbScriptsOnGossip> DbScriptsOnGossips { get; set; }
        public DbSet<CDbScriptsOnGoTemplateUse> DbScriptsOnGoTemplateUses { get; set; }
        public DbSet<CDbScriptsOnGoUse> DbScriptsOnGoUses { get; set; }
        public DbSet<CDbScriptsOnQuestEnd> DbScriptsOnQuestEnds { get; set; }
        public DbSet<CDbScriptsOnQuestStart> DbScriptsOnQuestStarts { get; set; }
        public DbSet<CDbScriptsOnRelay> DbScriptsOnRelays { get; set; }
        public DbSet<CDbScriptsOnSpell> DbScriptsOnSpells { get; set; }
        public DbSet<CDbScriptString> DbScriptStrings { get; set; }
        public DbSet<CDbScriptStringTemplate> DbScriptStringTemplates { get; set; }
        public DbSet<CDisenchantLootTemplate> DisenchantLootTemplates { get; set; }
        public DbSet<ExplorationBasexpBase> ExplorationBasexps { get; set; }
        public DbSet<CFishingLootTemplate> FishingLootTemplates { get; set; }
        public DbSet<CGameEvent> GameEvents { get; set; }
        public DbSet<CGameEventCreature> GameEventCreatures { get; set; }
        public DbSet<CGameEventCreatureData> GameEventCreatureDatas { get; set; }
        public DbSet<CGameEventGameobject> GameEventGameobjects { get; set; }
        public DbSet<CGameEventMail> GameEventMails { get; set; }
        public DbSet<CGameEventQuest> GameEventQuests { get; set; }
        public DbSet<CGameGraveyardZone> GameGraveyardZones { get; set; }
        public DbSet<CGameObject> GameObjects { get; set; }
        public DbSet<CGameObjectBattleground> GameObjectBattlegrounds { get; set; }
        public DbSet<CGameObjectInvolvedrelation> GameObjectInvolvedrelations { get; set; }
        public DbSet<CGameObjectLootTemplate> GameObjectLootTemplates { get; set; }
        public DbSet<CGameObjectQuestrelation> GameObjectQuestrelations { get; set; }
        public DbSet<CGameObjectTemplate> GameObjectTemplates { get; set; }
        public DbSet<GameTeleBase> GameTeles { get; set; }
        public DbSet<GameWeatherBase> GameWeathers { get; set; }
        public DbSet<CGossipMenu> GossipMenus { get; set; }
        public DbSet<CGossipMenuOption> GossipMenuOptions { get; set; }
        public DbSet<CGossipTexts> GossipTexts { get; set; }
        public DbSet<CInstanceDungeonEncounters> InstanceDungeonEncounters { get; set; }
        public DbSet<CInstanceEncounters> InstanceEncounters { get; set; }
        public DbSet<CInstanceTemplate> InstanceTemplates { get; set; }
        public DbSet<ItemEnchantmentTemplateBase> ItemEnchantmentTemplates { get; set; }
        public DbSet<CItemLootTemplate> ItemLootTemplates { get; set; }
        public DbSet<CItemRequiredTarget> ItemRequiredTargets { get; set; }*/
        public DbSet<CItemTemplate> ItemTemplates { get; set; }
        /*public DbSet<CLocalesCreature> LocalesCreatures { get; set; }
        public DbSet<CLocalesGameobject> LocalesGameobjects { get; set; }
        public DbSet<CLocalesGossipMenuOption> LocalesGossipMenuOptions { get; set; }
        public DbSet<CLocalesItem> LocalesItems { get; set; }
        public DbSet<CLocalesNpcText> LocalesNpcTexts { get; set; }
        public DbSet<CLocalesPageText> LocalesPageTexts { get; set; }
        public DbSet<CLocalesPointsOfInterest> LocalesPointsOfInterests { get; set; }
        public DbSet<CLocalesQuest> LocalesQuests { get; set; }
        public DbSet<CLocalesQuestgiverGreeting> LocalesQuestgiverGreetings { get; set; }
        public DbSet<CLocalesTrainerGreeting> LocalesTrainerGreetings { get; set; }
        public DbSet<CMailLootTemplate> MailLootTemplates { get; set; }
        public DbSet<CMangosString> MangosStrings { get; set; }
        public DbSet<CNpcGossip> NpcGossips { get; set; }
        public DbSet<CNpcText> NpcTexts { get; set; }
        public DbSet<CNpcTrainer> NpcTrainers { get; set; }
        public DbSet<CNpcTrainerTemplate> NpcTrainerTemplates { get; set; }*/
        public DbSet<CNpcVendor> NpcVendors { get; set; }
        public DbSet<CNpcVendorTemplate> NpcVendorTemplates { get; set; }
        /* public DbSet<CPageText> PageTexts { get; set; }
        public DbSet<CPetCreateInfoSpell> PetCreateInfoSpells { get; set; }
        public DbSet<CPetFamilyStats> PetFamilyStats { get; set; }
        public DbSet<PetLevelStatsBase> PetLevelStats { get; set; }
        public DbSet<CPetNameGeneration> PetNameGenerations { get; set; }*/
        public DbSet<CPickPocketingLootTemplate> PickPocketingLootTemplates { get; set; }
        /*public DbSet<PlayerClassLevelStatsBase> PlayerClassLevelStats { get; set; }
        public DbSet<PlayerCreateInfoBase> PlayerCreateInfos { get; set; }
        public DbSet<PlayerCreateInfoActionBase> PlayerCreateInfoActions { get; set; }
        public DbSet<PlayerCreateInfoItemBase> PlayerCreateInfoItems { get; set; }
        public DbSet<CPlayerCreateInfoSpell> PlayerCreateInfoSpells { get; set; }
        public DbSet<PlayerLevelStatsBase> PlayerLevelStats { get; set; }
        public DbSet<CPlayerXpForLevel> PlayerXpForLevels { get; set; }
        public DbSet<CPointsOfInterest> PointsOfInterests { get; set; }
        public DbSet<PoolCreatureBase> PoolCreatures { get; set; }
        public DbSet<CPoolCreatureTemplate> PoolCreatureTemplates { get; set; }
        public DbSet<PoolGameObjectBase> PoolGameObjects { get; set; }
        public DbSet<CPoolGameObjectTemplate> PoolGameObjectTemplates { get; set; }
        public DbSet<PoolPoolBase> PoolPools { get; set; }
        public DbSet<PoolTemplateBase> PoolTemplates { get; set; }
        public DbSet<CQuestGiverGreeting> QuestGiverGreetings { get; set; }
        public DbSet<CQuestTemplate> QuestTemplates { get; set; }*/
        public DbSet<CReferenceLootTemplate> ReferenceLootTemplates { get; set; }
        public DbSet<CReferenceLootTemplateNames> ReferenceLootTemplateNames { get; set; }
        /*public DbSet<ReputationRewardRateBase> ReputationRewardRates { get; set; }
        public DbSet<ReputationSpilloverTemplateBase> ReputationSpilloverTemplates { get; set; }
        public DbSet<CReservedName> ReservedNames { get; set; }
        public DbSet<CScriptedAreaTrigger> ScriptedAreaTriggers { get; set; }
        public DbSet<CScriptedEventId> ScriptedEventIds { get; set; }
        public DbSet<CScriptTexts> ScriptTexts { get; set; }
        public DbSet<CScriptWaypoint> ScriptWaypoints { get; set; }
        public DbSet<SkillFishingBaseLevelBase> SkillFishingBaseLevels { get; set; }
        public DbSet<CSkinningLootTemplate> SkinningLootTemplates { get; set; }
        public DbSet<CSpamRecords> SpamRecords { get; set; }
        public DbSet<CSpellAffect> SpellAffects { get; set; }
        public DbSet<CSpellArea> SpellAreas { get; set; }
        public DbSet<CSpellBonusData> CSpellBonusDatas { get; set; }
        public DbSet<CSpellChain> SpellChains { get; set; }
        public DbSet<CSpellElixir> SpellElixirs { get; set; }
        public DbSet<CSpellFacing> SpellFacings { get; set; }
        public DbSet<SpellLearnSpellBase> SpellLearnSpells { get; set; }
        public DbSet<SpellPetAurasBase> SpellPetAuras { get; set; }
        public DbSet<CSpellProcEvent> SpellProcEvents { get; set; }
        public DbSet<CSpellProcItemEnchant> SpellProcItemEnchants { get; set; }
        public DbSet<CSpellScriptTarget> SpellScriptTargets { get; set; }
        public DbSet<CSpellTargetPosition> SpellTargetPositions { get; set; }
        public DbSet<CSpellTemplate> SpellTemplates { get; set; }
        public DbSet<CSpellThreat> SpellThreats { get; set; }
        public DbSet<CTaxiShortcuts> TaxiShortcuts { get; set; }
        public DbSet<CTrainerGreeting> TrainerGreetings { get; set; }
        public DbSet<CTransports> Transportss { get; set; }
        public DbSet<CWorldTemplate> WorldTemplates { get; set; }*/
    }
}
