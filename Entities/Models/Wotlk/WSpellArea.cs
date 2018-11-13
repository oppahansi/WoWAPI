using System;
using Entities.Models.Common;

namespace Entities.Models.Wotlk
{
    public class WSpellArea : SpellAreaBase
    {
        public int QuestStartStatus { get; set; }
        public int QuestEndStatus { get; set; }
    }
}
