using System;
namespace wowapi.Entities.Enumerations
{
    public static class CreatureEnums
    {
        public enum CreatureExtraFlags
        {

            CREATURE_EXTRA_FLAG_INSTANCE_BIND               = 1,        // creature kill bind instance with killer and killer's group
            CREATURE_EXTRA_FLAG_NO_AGGRO_ON_SIGHT           = 2,        // no aggro (ignore faction/reputation hostility)
            CREATURE_EXTRA_FLAG_NO_PARRY                    = 4,        // creature can't parry
            CREATURE_EXTRA_FLAG_NO_PARRY_HASTEN             = 8,        // creature can't counter-attack at parry
            CREATURE_EXTRA_FLAG_NO_BLOCK                    = 16,       // 1creature can't block
            CREATURE_EXTRA_FLAG_NO_CRUSH                    = 32,       // creature can't do crush attacks
            CREATURE_EXTRA_FLAG_NO_XP_AT_KILL               = 64,       // creature kill not provide XP
            CREATURE_EXTRA_FLAG_INVISIBLE                   = 128,      // creature is always invisible for player (mostly trigger creatures)
            CREATURE_EXTRA_FLAG_NOT_TAUNTABLE               = 256,      // creature is immune to taunt auras and effect attack me
            CREATURE_EXTRA_FLAG_AGGRO_ZONE                  = 512,      // creature sets itself in combat with zone on aggro
            CREATURE_EXTRA_FLAG_GUARD                       = 1024,     // creature is a guard
            CREATURE_EXTRA_FLAG_NO_CALL_ASSIST              = 2048,     // creature shouldn't call for assistance on aggro
            CREATURE_EXTRA_FLAG_ACTIVE                      = 4096,     // creature is active object. Grid of this creature will be loaded and creature set as active
            CREATURE_EXTRA_FLAG_MMAP_FORCE_ENABLE           = 8192,     // creature is forced to use MMaps
            CREATURE_EXTRA_FLAG_MMAP_FORCE_DISABLE          = 16384,    // creature is forced to NOT use MMaps
            CREATURE_EXTRA_FLAG_WALK_IN_WATER               = 32768,    // creature is forced to walk in water even it can swim
            CREATURE_EXTRA_FLAG_CIVILIAN                    = 65536,    // CreatureInfo->civilian substitute (for new expansions)
            CREATURE_EXTRA_FLAG_NO_MELEE                    = 131072,   // creature can't melee
            CREATURE_EXTRA_FLAG_FORCE_ATTACKING_CAPABILITY  = 524288,   // SetForceAttackingCapability(true); for nonattackable, nontargetable creatures that should be able to attack nontheless
            CREATURE_EXTRA_FLAG_COUNT_SPAWNS                = 2097152,  // count creature spawns in Map*
            CREATURE_EXTRA_FLAG_HASTE_SPELL_IMMUNITY        = 4194304,  // immunity to COT or Mind Numbing Poison - very common in instances
        };
    }
}
