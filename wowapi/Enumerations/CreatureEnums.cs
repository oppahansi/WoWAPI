using System;
namespace wowapi.Enumerations
{
    public static class CreatureEnums
    {
        public enum CreatureExtraFlags
        {
            CREATURE_EXTRA_FLAG_INSTANCE_BIND               = 0x00000001,   // 1 creature kill bind instance with killer and killer's group
            CREATURE_EXTRA_FLAG_NO_AGGRO_ON_SIGHT           = 0x00000002,   // 2 no aggro (ignore faction/reputation hostility)
            CREATURE_EXTRA_FLAG_NO_PARRY                    = 0x00000004,   // 4 creature can't parry
            CREATURE_EXTRA_FLAG_NO_PARRY_HASTEN             = 0x00000008,   // 8 creature can't counter-attack at parry
            CREATURE_EXTRA_FLAG_NO_BLOCK                    = 0x00000010,   // 16 creature can't block
            CREATURE_EXTRA_FLAG_NO_CRUSH                    = 0x00000020,   // 32 creature can't do crush attacks
            CREATURE_EXTRA_FLAG_NO_XP_AT_KILL               = 0x00000040,   // 64 creature kill not provide XP
            CREATURE_EXTRA_FLAG_INVISIBLE                   = 0x00000080,   // 128 creature is always invisible for player (mostly trigger creatures)
            CREATURE_EXTRA_FLAG_NOT_TAUNTABLE               = 0x00000100,   // 256 creature is immune to taunt auras and effect attack me
            CREATURE_EXTRA_FLAG_AGGRO_ZONE                  = 0x00000200,   // 512 creature sets itself in combat with zone on aggro
            CREATURE_EXTRA_FLAG_GUARD                       = 0x00000400,   // 1024 creature is a guard
            CREATURE_EXTRA_FLAG_NO_CALL_ASSIST              = 0x00000800,   // 2048 creature shouldn't call for assistance on aggro
            CREATURE_EXTRA_FLAG_ACTIVE                      = 0x00001000,   // 4096 creature is active object. Grid of this creature will be loaded and creature set as active
            CREATURE_EXTRA_FLAG_MMAP_FORCE_ENABLE           = 0x00002000,   // 8192 creature is forced to use MMaps
            CREATURE_EXTRA_FLAG_MMAP_FORCE_DISABLE          = 0x00004000,   // 16384 creature is forced to NOT use MMaps
            CREATURE_EXTRA_FLAG_WALK_IN_WATER               = 0x00008000,   // 32768 creature is forced to walk in water even it can swim
            CREATURE_EXTRA_FLAG_CIVILIAN                    = 0x00010000,   // 65536 CreatureInfo->civilian substitute (for new expansions)
            CREATURE_EXTRA_FLAG_NO_MELEE                    = 0x00020000,   // 131072 creature can't melee
            CREATURE_EXTRA_FLAG_FORCE_ATTACKING_CAPABILITY  = 0x00080000,   // 524288 SetForceAttackingCapability(true); for nonattackable, nontargetable creatures that should be able to attack nontheless
            CREATURE_EXTRA_FLAG_COUNT_SPAWNS                = 0x00200000,   // 2097152 count creature spawns in Map*
            CREATURE_EXTRA_FLAG_HASTE_SPELL_IMMUNITY        = 0x00400000,   // 4194304 immunity to COT or Mind Numbing Poison - very common in instances
        };

        public enum NpcFlags
        {
            UNIT_NPC_FLAG_NONE                              = 0x00000000,
            UNIT_NPC_FLAG_GOSSIP                            = 0x00000001,
            UNIT_NPC_FLAG_QUESTGIVER                        = 0x00000002,
            UNIT_NPC_FLAG_VENDOR                            = 0x00000004,
            UNIT_NPC_FLAG_FLIGHTMASTER                      = 0x00000008,
            UNIT_NPC_FLAG_TRAINER                           = 0x00000010,
            UNIT_NPC_FLAG_SPIRITHEALER                      = 0x00000020,
            UNIT_NPC_FLAG_SPIRITGUIDE                       = 0x00000040,
            UNIT_NPC_FLAG_INNKEEPER                         = 0x00000080,
            UNIT_NPC_FLAG_BANKER                            = 0x00000100,
            UNIT_NPC_FLAG_PETITIONER                        = 0x00000200,
            UNIT_NPC_FLAG_TABARDDESIGNER                    = 0x00000400,
            UNIT_NPC_FLAG_BATTLEMASTER                      = 0x00000800,
            UNIT_NPC_FLAG_AUCTIONEER                        = 0x00001000,
            UNIT_NPC_FLAG_STABLEMASTER                      = 0x00002000,
            UNIT_NPC_FLAG_REPAIR                            = 0x00004000,
            UNIT_NPC_FLAG_OUTDOORPVP                        = 0x20000000,
        };

        public enum SpellMechanics
        {
            MECHANIC_CHARM                                  = 1,
            MECHANIC_CONFUSED                               = 2,
            MECHANIC_DISARM                                 = 4,
            MECHANIC_DISTRACT                               = 8,
            MECHANIC_FEAR                                   = 16,
            MECHANIC_FUMBLE                                 = 32,
            MECHANIC_ROOT                                   = 64,
            MECHANIC_PACIFY                                 = 128,
            MECHANIC_SILENCE                                = 256,
            MECHANIC_SLEEP                                  = 512,
            MECHANIC_SNARE                                  = 1024,
            MECHANIC_STUN                                   = 2048,
            MECHANIC_FREEZE                                 = 4096,
            MECHANIC_KNOCKOUT                               = 8192,
            MECHANIC_BLEED                                  = 16384,
            MECHANIC_BANDAGE                                = 32768,
            MECHANIC_POLYMORPH                              = 65536,
            MECHANIC_BANISH                                 = 131072,
            MECHANIC_SHIELD                                 = 262144,
            MECHANIC_SHACKLE                                = 524288,
            MECHANIC_MOUNT                                  = 1048576,
            MECHANIC_PERSUADE                               = 2097152,
            MECHANIC_TURN                                   = 4194304,
            MECHANIC_HORROR                                 = 8388608,
            MECHANIC_INVULNERABILITY                        = 16777216,
            MECHANIC_INTERRUPT                              = 33554432,
            MECHANIC_DAZE                                   = 67108864,
            MECHANIC_DISCOVERY                              = 134217728,
            MECHANIC_IMMUNE_SHIELD                          = 268435456,
            MECHANIC_SAPPED                                 = 536870912,
        };
    }
}
