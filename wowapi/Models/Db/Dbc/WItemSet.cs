using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Dbc
{
    [Table("dbc_ItemSet_wotlk")]
    public class WItemSet
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Item1 { get; set; }
        public int Item2 { get; set; }
        public int Item3 { get; set; }
        public int Item4 { get; set; }
        public int Item5 { get; set; }
        public int Item6 { get; set; }
        public int Item7 { get; set; }
        public int Item8  { get; set; }
        public int Item9 { get; set; }
        public int Item10 { get; set; }
        public int bankItem1 { get; set; }
        public int bankItem2 { get; set; }
        public int bankItem3 { get; set; }
        public int bankItem4 { get; set; }
        public int bankItem5 { get; set; }
        public int bankItem6 { get; set; }
        public int bankItem7 { get; set; }
        public int SetSpell1 { get; set; }
        public int SetSpell2 { get; set; }
        public int SetSpell3 { get; set; }
        public int SetSpell4 { get; set; }
        public int SetSpell5 { get; set; }
        public int SetSpell6 { get; set; }
        public int SetSpell7 { get; set; }
        public int SetSpell8 { get; set; }
        public int SetThreshold1 { get; set; }
        public int SetThreshold2 { get; set; }
        public int SetThreshold3 { get; set; }
        public int SetThreshold4 { get; set; }
        public int SetThreshold5 { get; set; }
        public int SetThreshold6 { get; set; }
        public int SetThreshold7 { get; set; }
        public int SetThreshold8 { get; set; }
        public int RequiredSkill { get; set; }
        public int RequiredSkillRank { get; set; }
    }
}