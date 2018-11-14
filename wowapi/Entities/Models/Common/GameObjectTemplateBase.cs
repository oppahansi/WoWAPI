﻿using System;
using System.ComponentModel.DataAnnotations;

namespace wowapi.Entities.Models.Common
{
    public class GameObjectTemplateBase : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        public byte Type { get; set; }
        public uint DisplayId { get; set; }
        public string Name { get; set; }
        public float Size { get; set; }
        public uint Data0 { get; set; }
        public uint Data2 { get; set; }
        public uint Data3 { get; set; }
        public uint Data4 { get; set; }
        public uint Data5 { get; set; }
        public uint Data7 { get; set; }
        public uint Data8 { get; set; }
        public uint Data9 { get; set; }
        public uint Data10 { get; set; }
        public uint Data11 { get; set; }
        public uint Data12 { get; set; }
        public uint Data13 { get; set; }
        public uint Data14 { get; set; }
        public uint Data15 { get; set; }
        public uint Data16 { get; set; }
        public uint Data17 { get; set; }
        public uint Data18 { get; set; }
        public uint Data19 { get; set; }
        public uint Data20 { get; set; }
        public uint Data21 { get; set; }
        public uint Data22 { get; set; }
        public uint Data23 { get; set; }
        public string ScriptName { get; set; }
    }
}
