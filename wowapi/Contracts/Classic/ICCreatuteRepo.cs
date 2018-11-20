using System.Collections.Generic;
using System.Threading.Tasks;
using wowapi.Models.Db.Classic;

namespace wowapi.Contracts.Classic
{
    public interface ICCreatuteRepo
    {
        Task<CCreature> GetCreaturesByGuidAsync(uint guid);
        Task<IEnumerable<CCreature>> GetCreaturesById(uint id);
        Task<IEnumerable<CCreature>> GetCreaturesByMap(ushort map);
    }
}
