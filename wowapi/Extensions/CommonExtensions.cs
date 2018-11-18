using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using wowapi.Entities.Models.Classic;
using wowapi.Entities.Models.Common;

namespace wowapi.Extensions
{
    public static class CommonExtensions
    {
        public static IEnumerable<CCreatureTemplate> OrderCCreatureTemplates(this IEnumerable<CCreatureTemplate> qry, string sortOrder)
        {
            switch (sortOrder.ToLower())
            {
                case "subname":
                    return qry.OrderBy(x => x.SubName);
                case "minLevel":
                    return qry.OrderBy(x => x.MinLevel);
                case "maxlevel":
                    return qry.OrderBy(x => x.MaxLevel);
                case "family":
                    return qry.OrderBy(x => x.SubName);
                case "type":
                    return qry.OrderBy(x => x.CreatureType);
                case "npcflags":
                    return qry.OrderBy(x => x.NpcFlags);
                case "extraflags":
                    return qry.OrderBy(x => x.ExtraFlags);
                case "mechanicimmune":
                    return qry.OrderBy(x => x.MechanicImmuneMask);
                case "schoolimmune":
                    return qry.OrderBy(x => x.SchoolImmuneMask);
                case "civilian":
                    return qry.OrderBy(x => x.Civilian);
                case "name_desc":
                    return qry.OrderByDescending(x => x.Name);
                case "subname_desc":
                    return qry.OrderByDescending(x => x.SubName);
                case "minLevel_desc":
                    return qry.OrderByDescending(x => x.MinLevel);
                case "maxlevel_desc":
                    return qry.OrderByDescending(x => x.MaxLevel);
                case "family_desc":
                    return qry.OrderByDescending(x => x.SubName);
                case "type_desc":
                    return qry.OrderByDescending(x => x.CreatureType);
                case "npcflags_desc":
                    return qry.OrderByDescending(x => x.NpcFlags);
                case "extraflags_desc":
                    return qry.OrderByDescending(x => x.ExtraFlags);
                case "mechanicimmune_desc":
                    return qry.OrderByDescending(x => x.MechanicImmuneMask);
                case "schoolimmune_desc":
                    return qry.OrderByDescending(x => x.SchoolImmuneMask);
                case "civilian_desc":
                    return qry.OrderByDescending(x => x.Civilian);
                default:
                    return qry.OrderBy(x => x.Name);
            }
        }
    }
}