using System;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models.Common;

namespace Entities.Models.Classic
{
    [Table("npc_text")]
    public class CNpcText : NpcTextBase
    {
        public float Prob0 { get; set; }
        public float Prob1 { get; set; }
        public float Prob2 { get; set; }
        public float Prob3 { get; set; }
        public float Prob4 { get; set; }
        public float Prob5 { get; set; }
        public float Prob6 { get; set; }
        public float Prob7 { get; set; }
    }
}
