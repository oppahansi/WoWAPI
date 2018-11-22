using System.Collections.Generic;
using System.Threading.Tasks;
using wowapi.Models.Db.Dbc;
using wowapi.Models.Search;

namespace wowapi.Contracts.Dbc
{
    public interface IItemSetRepo
    {
        Task<IEnumerable<CItemSet>> GetItemSetsAsync(ItemSetFilterParams filterParams);
        Task<CItemSet> GetItemSetAsync(uint id);
        Task<CItemSet> GetItemSetAsync(string name);
    }
}