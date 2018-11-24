using Microsoft.EntityFrameworkCore;
using wowapi.Models.Db.Dbc;

namespace wowapi.Contexts
{
    public class DbcRepositoryContext : DbContext
    {
        public DbcRepositoryContext(DbContextOptions<DbcRepositoryContext> options)
            : base(options)
        {
        }

        DbSet<CItemSet> CItemSets { get; set; }
        DbSet<TItemSet> TItemSets { get; set; }
        DbSet<WItemSet> WItemSets { get; set; }
        DbSet<CItemDisplayInfo> CItemDisplayInfos { get; set; }
    }
}