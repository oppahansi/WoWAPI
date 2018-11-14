using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models.Classic;

namespace Contracts.Classic
{
    public interface ICCreatuteRepo
    {
        Task<CCreature> GetCreaturesByGuidAsync(uint guid);
        Task<IEnumerable<CCreature>> GetCreaturesById(uint id);
        Task<IEnumerable<CCreature>> GetCreaturesByMap(ushort map);
    }
}
