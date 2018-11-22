namespace wowapi.Models.Search
{
    public class ItemSetFilterParams : FilterParams
    {
        public string Name { get; set; } = null;
        public uint ItemEntry { get; set; } = 0;
    }
}