using System.Collections.Generic;
using System.Threading.Tasks;
using wowapi.Models.Db.Classic;
using wowapi.Models.Search;

namespace wowapi.Contracts.Classic
{
    public interface ICCreatureLootTemplateRepo
    {
        Task<IEnumerable<CCreatureLootTemplate>> GetCreatureLootTemplatesByEntryAsync(uint entry);
        Task<IEnumerable<CCreatureLootTemplate>> GetCreatureLootTemplateByItemEntryAsync(uint itemEntry);
    }
}
