using System.Collections.Generic;
using System.Threading.Tasks;
using wowapi.Models.Db.Classic;
using wowapi.Models.Search;

namespace wowapi.Contracts.Classic
{
    public interface ICItemTemplateRepo
    {
        Task<IEnumerable<CItemTemplate>> GetAllItemTemplatesAsync(ItemFilterParams filterParams);
        Task<CItemTemplate> GetItemByEntryAsync(uint entry);
        Task<CItemTemplate> GetItemByFiltersAsync(ItemFilterParams itemFilterParams);
    }
}