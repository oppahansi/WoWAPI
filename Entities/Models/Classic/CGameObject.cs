using System;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models.Common;

namespace Entities.Models.Classic
{
    [Table("gameobject")]
    public class CGameObject : GameObjectBase
    {
        public int Spawntimesecsmin { get; set; }
        public int Spawntimesecsmax { get; set; }
    }
}
