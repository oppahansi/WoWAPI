using System.Text;
using wowapi.Enumerations;

namespace wowapi.Models.Search
{
    public class FilterParams
    {
        public byte FilterType { get; set; } = (byte)CommonEnums.FilterTypes.ALL;
        public string SortOrder { get; set; } = "name";
        public byte Page { get; set; } = 1;
        public byte PageSize { get; set; } = 100;

        public override string ToString()
        {
            var properties = this.GetType().GetProperties();
            var builder = new StringBuilder();

            builder.Append($"[{this.GetType().ToString()}]\n");

            foreach (var property in properties)
                builder.Append($"[{property.Name}]: {property.GetValue(this, null)}\n");

            return builder.ToString();
        }

        public virtual string ToCacheString()
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