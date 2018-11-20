using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Classic
{
    [Table("gameobject")]
    public class CGameObject : GameObjectBase
    {
        public int Spawntimesecsmin { get; set; }
        public int Spawntimesecsmax { get; set; }
    }
}
