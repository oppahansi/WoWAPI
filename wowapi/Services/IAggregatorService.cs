using System.Threading.Tasks;
using wowapi.Models.Db.Classic;

namespace wowapi.Services
{
    public interface IAggregatorService
    {
         Task AggregateItemInfoAsync(CItemTemplate itemTemplate);
    }
}