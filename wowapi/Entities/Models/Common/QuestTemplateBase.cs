using System;
namespace wowapi.Entities.Models.Common
{
    public class QuestTemplateBase : IEntity
    {
        public byte MinLevel { get; set; }
        public short QuestLevel { get; set; }
        public string ObjectiveText1 { get; set; }
        public string ObjectiveText2 { get; set; }
        public string ObjectiveText3 { get; set; }
        public string ObjectiveText4 { get; set; }
    }
}
