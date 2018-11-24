using System.Threading.Tasks;
using wowapi.Models.Db.Dbc;

namespace wowapi.Contracts.Dbc
{
    public interface IItemDisplayInfoRepo
    {
        Task<CItemDisplayInfo> GetItemDisplayInfoAsync(uint id);
    }
}