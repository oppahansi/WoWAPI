using Contracts;
using LazyCache;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using wowapi.Contexts;
using wowapi.Enumerations;

namespace wowapi.Repository.Classic
{
    public abstract class CRepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected CRepositoryContext RepositoryContext { get; set; }
        protected readonly IAppCache Cache;

        public CRepositoryBase(CRepositoryContext repositoryContext, IAppCache cache)
        {
            this.RepositoryContext = repositoryContext;
            this.Cache = cache;
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            IEnumerable<T> result = await Cache.GetOrAddAsync(typeof(T).ToString(), async () =>
            {
                return await this.RepositoryContext.Set<T>().ToListAsync();
            }, new TimeSpan(12, 0, 0));             
        
            return result;
        }

        public async Task<IEnumerable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression, string cacheFiltersString)
        {
            IEnumerable<T> result = await Cache.GetOrAddAsync(cacheFiltersString, async () =>
            {
                return await this.RepositoryContext.Set<T>().Where(expression).ToListAsync();
            }, new TimeSpan(12, 0, 0));             
        
            return result;
        }

        public async Task<IEnumerable<T>> FindAllByConditionsAsync(List<Func<T, bool>> filters, byte filterType, string cacheFiltersString)
        {
            IEnumerable<T> result = await Cache.GetOrAddAsync(cacheFiltersString, async () =>
            {
                switch(filterType)
                {
                    case (byte)CommonEnums.FilterTypes.ANY:
                        return await this.RepositoryContext.Set<T>().Where(x => filters.Any(f => f(x))).ToListAsync();
                    default:
                        return await this.RepositoryContext.Set<T>().Where(x => filters.All(f => f(x))).ToListAsync();
                }
            }, new TimeSpan(12, 0, 0));             
        
            return result;
            
        }

        public void Create(T entity)
        {
            this.RepositoryContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.RepositoryContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.RepositoryContext.Set<T>().Remove(entity);
        }

        public async Task SaveAsync()
        {
            await this.RepositoryContext.SaveChangesAsync();
        }
    }
}
