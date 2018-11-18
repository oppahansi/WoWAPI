using System.Reflection;
using System.Text;
using wowapi.Enumerations;

namespace wowapi.Entities.Models.Search
{
    public class CreatureFilterParams
    {
        public byte FilterType { get; set; } = (byte)CommonEnums.FilterTypes.ALL;
        public string Name { get; set; } = null;
        public string SubName { get; set; } = null;
        public byte MinLevel { get; set; } = 0;
        public byte MaxLevel { get; set; } = 0;
        public sbyte Family { get; set; } = 0;
        public byte Type { get; set; } = 100;
        public uint NpcFlags { get; set; } = 0;
        public uint ExtraFlags { get; set; } = 0;
        public uint MechanicImmuneMask { get; set; } = 0;
        public uint SchoolImmuneMask { get; set; } = 0;
        public byte Civilian { get; set; } = 2;
        public string SortOrder { get; set; } = "name";

        public override string ToString()
        {
            var properties = this.GetType().GetProperties();
            var builder = new StringBuilder();

            builder.Append($"[{this.GetType().ToString()}]\n");

            foreach (var property in properties)
                builder.Append($"[{property.Name}]: {property.GetValue(this, null)}\n");

            return builder.ToString();
        }

        public  string ToCacheString()
        {
            var properties = this.GetType().GetProperties();
            var builder = new StringBuilder();

            builder.Append($"[{this.GetType().ToString()}]");

            foreach (var property in properties)
                builder.Append($"[{property.Name}]:{property.GetValue(this, null)}");

            return builder.ToString();
        }
    }
}