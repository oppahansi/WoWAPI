using System.Collections.Generic;

namespace wowapi.Dictionaries
{
    public static class CreatureDictionary
    {
        public static readonly Dictionary<byte, string> CreatureTypes = new Dictionary<byte, string>
        {
            {0, "None"              },
            {1, "Beast"             },
            {2, "Dragonkin"         },
            {3, "Demon"             },
            {4, "Elemental"         },
            {5, "Giant"             },
            {6, "Undead"            },
            {7, "Humanoid"          },
            {8, "Critter"           },
            {9, "Mechanical"        },
            {10, "Not specified"    },
            {11, "Totem"            },
            {12, "Non-combat Pet"   },
            {13, "Gas Cloud"        }
        };

        public static readonly Dictionary<byte, string> Ranks = new Dictionary<byte, string>
        {
            {0, "Normal"    },
            {1, "Elite"     },
            {2, "Rare Elite"},
            {3, "World Boss"},
            {4, "Rare"      }
        };

        public static readonly Dictionary<uint, string> ExtraFlags = new Dictionary<uint, string>
        {
            {0x00000001, "Binds to instance"                                        },
            {0x00000002, "Doesn't aggro"                                            },
            {0x00000004, "Can’t parry"                                              },
            {0x00000008, "Can’t counter-attack at parry"                            },
            {0x00000010, "Can’t block"                                              },
            {0x00000020, "Can’t do crush attacks"                                   },
            {0x00000040, "Kill doesn't provide XP"                                  },
            {0x00000080, "Invisible to players"                                     },
            {0x00000100, "Immune to taunt"                                          },
            {0x00000200, "Sets itself in combat with zone on Aggro"                 },
            {0x00000400, "Is a guard"                                               },
            {0x00000800, "Doesn't call for assistance on aggro"                     },
            {0x00001000, "Active object"                                            },
            {0x00002000, "Uses MMaps"                                               },
            {0x00004000, "Doesn't use MMaps"                                        },
            {0x00008000, "Forced to walk in water"                                  },
            {0x00010000, "Civilian"                                                 },
            {0x00020000, "Can’t melee"                                              },
            {0x00040000, "With far view"                                            },
            {0x00080000, "Nonattackable, nontargetable able to attack nontheless"   },
            {0x00100000, "Ignore used positions"                                    },
            {0x00200000, "Count creature spawns in Map"                             },
            {0x00400000, "Immunity to COT or Mind Numbing Poison"                   }
        };

        public static readonly Dictionary<uint, string> NpcFlags = new Dictionary<uint, string>
        {
            {0x00000000, "None"             },
            {0x00000001, "Gossip"           },
            {0x00000002, "Quest giver"      },
            {0x00000004, "Vendor"           },
            {0x00000008, "Flight master"    },
            {0x00000010, "Trainer"          },
            {0x00000020, "Spirit healer"    },
            {0x00000040, "Spirit guide"     },
            {0x00000080, "Innkeeper"        },
            {0x00000100, "Banker"           },
            {0x00000200, "Petitioner"       },
            {0x00000400, "Tabarddesigner"   },
            {0x00000800, "Battlemaster"     },
            {0x00001000, "Auctioneer"       },
            {0x00002000, "Stablemaster"     },
            {0x00004000, "Repair"           },
            {0x20000000, "Outdoorpvp"       }
        };

        public static readonly Dictionary<uint, string> SpellMechanic = new Dictionary<uint, string>
        {
            {1,         "Charm"             },
            {2,         "Confused"          },
            {4,         "Disarm"            },
            {8,         "Distract"          },
            {16,        "Fear"              },
            {32,        "Fumble"            },
            {64,        "Root"              },
            {128,       "Pacify"            },
            {256,       "Silence"           },
            {512,       "Sleep"             },
            {1024,      "Snare"             },
            {2048,      "Stun"              },
            {4096,      "Freeze"            },
            {8192,      "Knockout"          },
            {16384,     "Bleed"             },
            {32768,     "Bandage"           },
            {65536,     "Polymorphe"        },
            {131072,    "Banish"            },
            {262144,    "Shield"            },
            {524288,    "Shackle"           },
            {1048576,   "Mount"             },
            {2097152,   "Persuade"          },
            {4194304,   "Turn"              },
            {8388608,   "Horror"            },
            {16777216,  "Invulnerabilility" },
            {33554432,  "Interrupt"         },
            {67108864,  "Daze"              },
            {134217728, "Discovery"         },
            {268435456, "Immune Shield"     },
            {536870912, "Sapped"            }
        };
    }
}
